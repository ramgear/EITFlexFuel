using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EITFlex
{
    using EITFlex.Datas;
    using EITFlex.Controls;
    using EITFlex.Devices;

    public partial class FrmMainForm : Form
    {
        class TabButtonHander
        {
            private TabControl mTcparent;
            private List<TabButton> mButtons;

            public TabButtonHander(TabControl tc)
            {
                mButtons = new List<TabButton>();
                mTcparent = tc;
            }

            public void AddButton(TabButton btn, TabPage tp)
            {
                btn.Tag = tp;
                btn.Click += OnButtonClicked;
                this.mButtons.Add(btn);
            }

            private void OnButtonClicked(object sender, EventArgs e)
            {
                foreach(TabButton btn in mButtons)
                {
                    if (btn == sender)
                        this.Select(btn);
                    else
                        btn.Selected = false;
                }
            }

            public void Select(TabButton btn)
            {
                btn.Selected = true;
                mTcparent.SelectedTab = btn.Tag as TabPage;
            }
        }

        class FuelMapReader
        {
            public UInt16 Offset { get; set; }
            public Byte Count { get; set; }
            public Byte[] Data { get; set; }

            public FuelMapReader(int rpmCount, int loadCount)
            {
                Offset = 0;
                Count = 57;
                Data = new Byte[rpmCount * loadCount];
            }
        }

        TabButtonHander mTbHandler;
        EITFlexBoard board;

        delegate void ConfigHandler(ConfigData cfg);
        delegate void SysMonHandler(SysMonData info);
        delegate void MsgHandler(string msg);
        delegate void StatHandler(bool stat);
        delegate void FuelMapHandler(Byte[] data);

        ConfigHandler cfgHandler;
        SysMonHandler sysMonHandler;
        MsgHandler msgHandler;
        StatHandler mStatHansler;
        FuelMapHandler mFuelMapHandler;

        bool mConfigReceived = false;
        ConfigData mConfigs;

        BackgroundWorker bgWorker;
        FuelMapReader mFuelReader;
        Queue<Byte[]> qData;

        int[] serialSpeeds = { 9600, 38400, 115200 };

        public FrmMainForm()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            tcMain.Appearance = TabAppearance.FlatButtons;
            tcMain.ItemSize = new Size(0, 1);
            mTbHandler = new TabButtonHander(tcMain);
            mTbHandler.AddButton(tbInfo, tpInfo);
            mTbHandler.AddButton(tbSettings, tpSetting);
            mTbHandler.AddButton(tbFuelMap, tpFuelMap);
            mTbHandler.AddButton(tbCommunication, tpComm);

            mTbHandler.Select(tbInfo);

            board = new EITFlexBoard();
            board.OnConfigDataReceived += board_OnConfigDataReceived;
            board.OnSysMonDataReceived += board_OnSysMonDataReceived;
            board.OnTextReceived += board_OnTextReceived;
            board.OnCommandgDataReceived += board_OnCommandgDataReceived;
            board.OnConnectionStatChanged += new EventHandler(board_OnConnectionStatChanged);
            board.OnConnectionTimeout += new EventHandler(board_OnConnectionTimeout);
            //board.PingCheck = true;

            cfgHandler = new ConfigHandler(this.loadConfig);
            sysMonHandler = new SysMonHandler(this.loadMonitoringInfo);
            msgHandler = new MsgHandler(this.FillMessage);
            mStatHansler = new StatHandler(this.SetConnectionStatFunc);
            mFuelMapHandler = new FuelMapHandler(this.setFuelMapTable);

            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
            qData = new Queue<Byte[]>();
        }

        void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (qData.Count > 0)
            {
                Byte[] data = qData.Dequeue();

                if (data != null && mFuelReader != null && mFuelReader.Data.Length != 0)
                {
                    UInt16 offset = BitConverter.ToUInt16(data, 0);
                    Byte count = data[2];
                    Array.Copy(data, 3, mFuelReader.Data, offset, count);

                    mFuelReader.Offset += count;
                    if (mFuelReader.Offset >= mFuelReader.Data.Length)
                    {
                        // Done
                        this.Invoke(mFuelMapHandler, mFuelReader.Data);

                        return;
                    }

                    // Read next offset
                    if (mFuelReader.Offset + mFuelReader.Count > mFuelReader.Data.Length)
                        mFuelReader.Count = (Byte)(mFuelReader.Data.Length - mFuelReader.Offset);
                }
            }

            if (mFuelReader != null && mFuelReader.Data.Length != 0)
            {
                Byte[] cmdData = new Byte[3];
                Byte[] offsetArray = BitConverter.GetBytes(mFuelReader.Offset);
                Array.Copy(offsetArray, cmdData, offsetArray.Length);
                cmdData[2] = mFuelReader.Count;

                board.SendCommand(CommandCodes.CMD_READ_MAPPING, cmdData);
            }
        }

        #region Methods

        void setFuelMapTable(Byte[] data)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;

            if (dt == null)
                return;

            int offset = 0;
            for (int row = 0; row < dt.Rows.Count; row++)
                for (int col = 0; col < dt.Columns.Count; col++)
                    dt.Rows[row][col] = data[offset++];

            this.DisplayText(string.Format("Fuel Mapping received {0} steps.", data.Length), true);
        }

        void FillMessage(string msg)
        {
            /*
            string[] lines = new string[tbxMessage.Lines.Length + 1];
            Array.Copy(tbxMessage.Lines, lines, tbxMessage.Lines.Length);
            lines[lines.Length - 1] = msg;
            tbxMessage.Lines = lines;
             */
            tbxMessage.Text += msg;
        }

        void DisplayText(string msg, bool dialog = false, bool newline = true)
        {
            if (newline)
                msg += Environment.NewLine;

            this.Invoke(msgHandler, msg);

            if (dialog)
                MessageBox.Show(msg, "Info Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadConfig(ConfigData e)
        {
            mDataLoading = true;

            mConfigs = e;
            mConfigReceived = true;

            // load features switch enable
            swFeatures.Stat = e.Features.Enabled != 0;
            swFuelMap.Stat = e.Features.FuelMapping != 0;
            swRPMAcc.Stat = e.Features.RPMAcceleration != 0;
            swLoadAcc.Stat = e.Features.MAPAcceleration != 0;
            swSysMon.Stat = e.Features.Monitoring != 0;
            swInjMon.Stat = e.Features.InjMonitoring != 0;

            swFeatures.Value1 = e.MaxAdjust;
            swFeatures.Value2 = e.ManualAdjust;

            swFuelMap.Value1 = e.RPMCount;
            swFuelMap.Value2 = e.MAPCount;

            swRPMAcc.Value2 = e.RPMAdjust;
            swRPMAcc.Value1 = e.RPMAdjustStep;

            swLoadAcc.Value2 = e.MAPAdjust;
            swLoadAcc.Value1 = e.MAPAdjustStep;

            /*
            cfgManualAdj.Value = e.ManualAdjust;
            cfgWarmupTime.Value = e.WarmUpTime;
            cfgWarmupRPM.Value = e.WarmUpRPM;
            cfgRevPerPulse.Value = e.RevPerPulse;*/

            numRPMStart.Value = e.RPMStart;
            numRPMStep.Value = (e.RPMEnd - e.RPMStart) / (e.RPMCount + 1);
            numRPMEnd.Value = e.RPMEnd;

            numLoadStart.Value = e.MAPStart;
            numLoadStep.Value = (e.MAPEnd - e.MAPStart) / (e.MAPCount + 1);
            numLoadEnd.Value = e.MAPEnd;

            createMapping(e);
            resetMapValue(e, false);

            btnFuelMapRead.PerformClick();

            mDataLoading = false;
        }

        void loadMonitoringInfo(SysMonData sysMon)
        {
            mDataLoading = true;
            scRPMDutyCycle.Value = sysMon.CurrentDuty;
            scRPM.Value = sysMon.CurrentRPM;
            scRPMAcc.Value = sysMon.CurrentRPMAcc;
            scFuelAdjust.Value = sysMon.FuelAdjust;
            scLoad.Value = sysMon.CurrentMAP;
            scLoadAcc.Value = sysMon.CurrentMAPAcc;
            mDataLoading = false;
        }

        bool mDataLoading = false;
        private void ClearDisplay()
        {

            // reset all values
            loadConfig(new ConfigData());
            loadMonitoringInfo(new SysMonData());

            dataGridView1.DataSource = null;
            mDataLoading = false;
        }

        private void SetConnectionStatFunc(bool connected)
        {
            if (connected)
            {
                btnSerialConnect.Enabled = false;
                btnSerialDisconnect.Enabled = true;
                gbSerialport.Enabled = false;
                gbSerialSpeed.Enabled = false;
                btnRefresh.Enabled = true;
                btnSendCmd.Enabled = true;
                txtCommandText.ReadOnly = false;

                swFeatures.ReadOnly = false;
                swFuelMap.ReadOnly = false;
                swInjMon.ReadOnly = false;
                swLoadAcc.ReadOnly = false;
                swRPMAcc.ReadOnly = false;
                swSysMon.ReadOnly = false;

                gpFuelMapSetting.Enabled = true;
                gpFuelMapTable.Enabled = true;

                this.DisplayText("Connected");
            }
            else
            {
                btnSerialConnect.Enabled = true;
                btnSerialDisconnect.Enabled = false;
                gbSerialport.Enabled = true;
                gbSerialSpeed.Enabled = true;
                btnRefresh.Enabled = false;
                btnSendCmd.Enabled = false;
                txtCommandText.ReadOnly = true;

                swFeatures.ReadOnly = true;
                swFuelMap.ReadOnly = true;
                swInjMon.ReadOnly = true;
                swLoadAcc.ReadOnly = true;
                swRPMAcc.ReadOnly = true;
                swSysMon.ReadOnly = true;

                gpFuelMapSetting.Enabled = false;
                gpFuelMapTable.Enabled = false;

                this.DisplayText("Disconnected");

                this.ClearDisplay();
            }
        }

        private void SetConnectionStat(bool connected)
        {
            this.Invoke(mStatHansler, connected);
        }

        private void createMapping(ConfigData config)
        {
            DataTable dt = new DataTable();
            int rpmCount = config.RPMCount;
            int rpmStart = config.RPMStart;
            int rpmStep = config.RPMStep;
            int rpmEnd = config.RPMEnd;

            int mapCount = config.MAPCount;
            int mapStart = config.MAPStart;
            int mapStep = config.MAPStep;
            int mapEnd = config.MAPEnd;

            if (rpmCount == 0 || rpmStep == 0 || mapCount == 0 || mapStep == 0)
                return;

            for (int col = 0; col < rpmCount; col++)
            {
                dt.Columns.Add((rpmStart + rpmStep * col).ToString());
            }
            for (int row = 0; row < mapCount; row++)
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);
            }

            dataGridView1.DataSource = dt;

            for (int col = 0; col < dataGridView1.ColumnCount; col++)
            {
                dataGridView1.Columns[col].Width = 60;
            }
            for (int row = 0; row < mapCount; row++)
            {
                dataGridView1.Rows[row].HeaderCell.Value = (mapStart + mapStep * row).ToString();
            }
        }

        private void resetMapValue(ConfigData config, bool autoCal = false)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;

            if (dt == null)
                return;

            double val = 0;
            double adj = config.MaxAdjust - config.ManualAdjust;
            for (int row = 0; row < config.MAPCount; row++)
            {
                for (int col = 0; col < config.RPMCount; col++)
                {
                    if (autoCal)
                    {
                        val = System.Math.Sqrt(((double)(col * col) / (config.RPMCount * config.RPMCount) + (double)(row * row) / (config.MAPCount * config.MAPCount)));
                        val = adj * val / 1.4142;
                    }

                    dt.Rows[row][col] = (int)val;

                }
            }
        }

        private void ShowErrorDialog(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error Dialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ChangeConfigs(ConfigData cfg)
        {
            board.SendCommand(CommandCodes.CMD_WRITE_CONFIGS, cfg);
        }

        #endregion

        #region Override function

        protected override void OnClosing(CancelEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to exit from application?", "Question Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                }

                // save settings
                Properties.Settings.Default.PortName = board.PortName;
                Properties.Settings.Default.BaudRate = board.BaudRate;
                Properties.Settings.Default.Save();

            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        #endregion

        #region Event handlers

        void board_OnConnectionTimeout(object sender, EventArgs e)
        {
            try
            {
                this.DisplayText("Connection timeout!");
                this.SetConnectionStat(false);
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        void board_OnConnectionStatChanged(object sender, EventArgs e)
        {
            try
            {
                this.SetConnectionStat(board.Connected);

                if (board.Connected)
                {
                    board.SendCommand(CommandCodes.CMD_READ_CONFIGS);
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        void board_OnCommandgDataReceived(object sender, CommandData e)
        {
            try
            {
                CommandCodes code = (CommandCodes)e.CommandCode;

                if (code == CommandCodes.CMD_READ_MAPPING)
                {
                    qData.Enqueue(e.Data);
                    if (!bgWorker.IsBusy)
                        bgWorker.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        void board_OnTextReceived(object sender, string e)
        {
            try
            {
                this.DisplayText(e, false, false);
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        void board_OnSysMonDataReceived(object sender, SysMonData e)
        {
            try
            {
                this.Invoke(sysMonHandler, e);
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        void board_OnConfigDataReceived(object sender, ConfigData e)
        {
            try
            {
                this.Invoke(cfgHandler, e);
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }
        
        private void txtCmdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    board.SendCommand(txtCommandText.Text);
                    txtCommandText.SelectAll();
                    txtCommandText.Focus();
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void FrmMainForm_Load(object sender, EventArgs e)
        {
            try
            {
                board.PortName = Properties.Settings.Default.PortName;
                board.BaudRate = Properties.Settings.Default.BaudRate;

                string[] serialPorts = EITFlexBoard.GetPortNames();
                foreach(string port in serialPorts)
                {
                    RadioButton ctrl = new RadioButton();
                    ctrl.Text = port;
                    ctrl.Location = new Point(20, 40 * (gbSerialport.Controls.Count + 1));
                    ctrl.CheckedChanged += serialPort_CheckedChanged;
                    gbSerialport.Controls.Add(ctrl);
                    if (port == board.PortName)
                        ctrl.Checked = true;
                }

                foreach (int speed in serialSpeeds)
                {
                    RadioButton ctrl = new RadioButton();
                    ctrl.Text = speed.ToString();
                    ctrl.Location = new Point(20, 40 * (gbSerialSpeed.Controls.Count + 1));
                    ctrl.CheckedChanged += serialSpeed_CheckedChanged;
                    gbSerialSpeed.Controls.Add(ctrl);
                    if (speed == board.BaudRate)
                        ctrl.Checked = true;
                }

                if(gbSerialport.Controls.Count > 0)
                {
                    btnSerialConnect.Enabled = true;
                }

                SetConnectionStat(false);
                tbCommunication.PerformClick();
              
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        void serialPort_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton ctrl = sender as RadioButton;
                if (ctrl.Checked)
                    board.PortName = ctrl.Text;
            }
            catch
            {
            }
        }

        void serialSpeed_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton ctrl = sender as RadioButton;
                if (ctrl.Checked)
                    board.BaudRate = int.Parse(ctrl.Text);
            }
            catch
            {
            }
        }
        
        private void btnSerialConnect_Click(object sender, EventArgs e)
        {
            try
            {
                this.DisplayText("Connecting to device.");
                btnSerialConnect.Enabled = gbSerialport.Enabled = gbSerialSpeed.Enabled = false;

                if(board.Connect())
                {
                }

            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
                btnSerialConnect.Enabled = gbSerialport.Enabled = gbSerialSpeed.Enabled = true;
            }
        }

        private void btnSerialDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                this.DisplayText("Disconnect from device.");
                if (board.Disconnect())
                {
                }

            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void btnSendCmd_Click(object sender, EventArgs e)
        {
            try
            {
                board.SendCommand(txtCommandText.Text);
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void swFeatures_OnStatChanged(object sender, EventArgs e)
        {
            try
            {
                if (mConfigReceived && !mDataLoading)
                {
                    mConfigs.Features.Enabled = (Byte)(!swFeatures.Stat ? 1 : 0 );
                    ChangeConfigs(mConfigs);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void swFuelMap_OnStatChanged(object sender, EventArgs e)
        {
            try
            {
                if (mConfigReceived && !mDataLoading)
                {
                    mConfigs.Features.FuelMapping = (Byte)(!swFuelMap.Stat ? 1 : 0);
                    ChangeConfigs(mConfigs);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void swRPMAcc_OnStatChanged(object sender, EventArgs e)
        {
            try
            {
                if (mConfigReceived && !mDataLoading)
                {
                    mConfigs.Features.RPMAcceleration = (Byte)(!swRPMAcc.Stat ? 1 : 0);
                    ChangeConfigs(mConfigs);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void swLoadAcc_OnStatChanged(object sender, EventArgs e)
        {
            try
            {
                if (mConfigReceived && !mDataLoading)
                {
                    mConfigs.Features.MAPAcceleration = (Byte)(!swLoadAcc.Stat ? 1 : 0);
                    ChangeConfigs(mConfigs);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void swSysMon_OnStatChanged(object sender, EventArgs e)
        {
            try
            {
                if (mConfigReceived && !mDataLoading)
                {
                    mConfigs.Features.Monitoring = (Byte)(!swSysMon.Stat ? 1 : 0);
                    ChangeConfigs(mConfigs);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void swInjMon_OnStatChanged(object sender, EventArgs e)
        {
            try
            {
                if (mConfigReceived && !mDataLoading)
                {
                    mConfigs.Features.InjMonitoring = (Byte)(!swInjMon.Stat ? 1 : 0);
                    ChangeConfigs(mConfigs);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void swRPMAcc_OnSet(object sender, EventArgs e)
        {
            try
            {
                if (mConfigReceived)
                {
                    mConfigs.RPMAdjustStep = (UInt16)swRPMAcc.Value1;
                    mConfigs.RPMAdjust = (Byte)swRPMAcc.Value2;
                    ChangeConfigs(mConfigs);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void swLoadAcc_OnSet(object sender, EventArgs e)
        {
            try
            {
                if (mConfigReceived)
                {
                    mConfigs.MAPAdjustStep = (Byte)swLoadAcc.Value1;
                    mConfigs.MAPAdjust = (Byte)swLoadAcc.Value2;
                    ChangeConfigs(mConfigs);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void swFeatures_OnSet(object sender, EventArgs e)
        {
            try
            {
                if (mConfigReceived)
                {
                    mConfigs.MaxAdjust = (Byte)swFeatures.Value1;
                    mConfigs.ManualAdjust = (Byte)swFeatures.Value2;
                    ChangeConfigs(mConfigs);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void swFuelMap_OnSet(object sender, EventArgs e)
        {
            try
            {
                if (mConfigReceived)
                {
                    mConfigs.RPMCount = (Byte)swFuelMap.Value1;
                    mConfigs.MAPCount = (Byte)swFuelMap.Value2;
                    ChangeConfigs(mConfigs);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                board.SendCommand(CommandCodes.CMD_READ_CONFIGS);
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void btnClearMessage_Click(object sender, EventArgs e)
        {
            try
            {
                tbxMessage.Text = string.Empty;
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        #endregion

        private void btnFuelMapApply_Click(object sender, EventArgs e)
        {
            try
            {
                mConfigs.RPMStart = (UInt16)numRPMStart.Value;
                mConfigs.RPMEnd = (UInt16)numRPMEnd.Value;
                mConfigs.RPMStep = (UInt16)((mConfigs.RPMEnd - mConfigs.RPMStart) / (mConfigs.RPMCount + 1));
                numRPMEnd.Value = mConfigs.RPMStep;

                mConfigs.MAPStart = (Byte)numLoadStart.Value;
                mConfigs.MAPEnd = (Byte)numLoadEnd.Value;
                mConfigs.MAPStep = (Byte)((mConfigs.MAPEnd - mConfigs.MAPStart) / (mConfigs.MAPCount + 1));
                numLoadEnd.Value = mConfigs.MAPStep;
                ChangeConfigs(mConfigs);

                createMapping(mConfigs);
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void btnFuelMapCal_Click(object sender, EventArgs e)
        {
            try
            {
                resetMapValue(mConfigs, true);
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void btnFuelMapRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (mConfigs.RPMCount != 0 && mConfigs.MAPCount != 0)
                {
                    if (bgWorker.IsBusy)
                        bgWorker.CancelAsync();


                    mFuelReader = new FuelMapReader(mConfigs.RPMCount, mConfigs.MAPCount);
                    bgWorker.RunWorkerAsync();
                    this.DisplayText("Reading fuel mapping.");
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }
    }
}
