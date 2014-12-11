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
            private List<TabPage> mPages;

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

        TabButtonHander mTbHandler;
        EITFlexBoard board;

        delegate void ConfigHandler(ConfigData cfg);
        delegate void SysMonHandler(SysMonData info);
        delegate void MsgHandler(string msg);
        delegate void InjectorHandler(InjectorData info);
        delegate void StatHandler(bool stat);

        ConfigHandler cfgHandler;
        SysMonHandler sysMonHandler;
        MsgHandler msgHandler;
        InjectorHandler injHandler;
        StatHandler mStatHansler;

        bool mConfigReceived = false;
        ConfigData mConfigs;

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
            board.OnInjectorDataReceived += board_OnInjectorDataReceived;
            board.OnConnectionStatChanged += new EventHandler(board_OnConnectionStatChanged);
            board.OnConnectionTimeout += new EventHandler(board_OnConnectionTimeout);

            cfgHandler = new ConfigHandler(this.loadConfig);
            sysMonHandler = new SysMonHandler(this.loadMonitoringInfo);
            msgHandler = new MsgHandler(this.FillMessage);
            injHandler = new InjectorHandler(this.loadInjectorInfo);
            mStatHansler = new StatHandler(this.SetConnectionStatFunc);
        }

        #region Methods

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

        void DisplayText(string msg, bool newline = true)
        {
            if (newline)
                msg += Environment.NewLine;

            this.Invoke(msgHandler, msg);
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

            //cfgRPMCount.Value = e.RPMCount;
            cfgRPMStart.Value = e.RPMStart;
            cfgRPMEnd.Value = e.RPMEnd;

            //cfgLoadCount.Value = e.MAPCount;
            cfgLoadStart.Value = e.MAPStart;
            cfgLoadEnd.Value = e.MAPEnd;

            createMapping(e);
            resetMapValue(e, true);
            mDataLoading = false;
        }

        void loadMonitoringInfo(SysMonData sysMon)
        {
            mDataLoading = true;
            scFuelAdjust.Value = sysMon.FuelAdjust;
            scLoad.Value = sysMon.CurrentMAP;
            scLoadAcc.Value = sysMon.CurrentMAPAcc;
            mDataLoading = false;
        }

        void loadInjectorInfo(InjectorData inj)
        {
            mDataLoading = true;
            scRPMDutyCycle.Value = inj.CurrentDuty;
            scRPM.Value = inj.CurrentRPM;
            scRPMAcc.Value = inj.CurrentRPMAcc;
            mDataLoading = false;
        }

        bool mDataLoading = false;
        private void ClearDisplay()
        {

            // reset all values
            loadConfig(new ConfigData());
            loadInjectorInfo(new InjectorData());
            loadMonitoringInfo(new SysMonData());
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

                this.DisplayText("Connected");
            }
            else
            {
                btnSerialConnect.Enabled = true;
                btnSerialDisconnect.Enabled = false;
                gbSerialport.Enabled = true;
                gbSerialSpeed.Enabled = true;
                btnRefresh.Enabled = false;
                btnSendCmd.Enabled = true;
                txtCommandText.ReadOnly = true;

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
            int rpmEnd = config.RPMEnd;
            int rpmStep = config.RPMStep;

            int mapCount = config.MAPCount;
            int mapStart = config.MAPStart;
            int mapEnd = config.MAPEnd;
            int mapStep = config.MAPStep;

            if (rpmCount == 0 || rpmStart == 0 || rpmEnd == 0 || mapCount == 0 || mapStart == 0 || mapEnd == 0)
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
                dataGridView1.Rows[row].HeaderCell.Value = "test";// (mapStart + mapStep * row).ToString();
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

        void board_OnInjectorDataReceived(object sender, InjectorData e)
        {
            try
            {
                this.Invoke(injHandler, e);
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
                this.DisplayText(e, false);
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
              
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        void serialPort_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton ctrl = sender as RadioButton;
            if (ctrl.Checked)
                board.PortName = ctrl.Text;
        }

        void serialSpeed_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton ctrl = sender as RadioButton;
            if (ctrl.Checked)
                board.BaudRate = int.Parse(ctrl.Text);
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
    }
}
