using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.Runtime.InteropServices;

using EITFlex.Datas;
using EITFlex.Devices;

namespace EITFlex
{
    public partial class FrmMain : Form
    {
        EITFlexBoard board;
        ConfigData mConfigs;

        delegate void ConfigHandler(ConfigData cfg);
        delegate void SysMonHandler(SysMonData info);
        delegate void MsgHandler(string msg);

        ConfigHandler cfgHandler;
        SysMonHandler sysMonHandler;
        MsgHandler msgHandler;
        
        public FrmMain()
        {
            InitializeComponent();

            board = new EITFlexBoard();
            board.OnConfigDataReceived += board_OnConfigDataReceived;
            board.OnSysMonDataReceived += board_OnSysMonDataReceived;
            board.OnTextReceived += board_OnTextReceived;
            board.OnCommandgDataReceived += board_OnCommandgDataReceived;

            cfgHandler = new ConfigHandler(this.loadConfig);
            sysMonHandler = new SysMonHandler(this.loadMonitoringInfo);
            msgHandler = new MsgHandler(this.FillMessage);

            Console.WriteLine("SizeOf(CommandData) = {0}", Marshal.SizeOf(typeof(CommandData)));
            Console.WriteLine("SizeOf(FeatureDarta) = {0}", Marshal.SizeOf(typeof(FeatureDarta)));
            Console.WriteLine("SizeOf(InjectorData) = {0}", Marshal.SizeOf(typeof(InjectorData)));
            Console.WriteLine("SizeOf(SysMonData) = {0}", Marshal.SizeOf(typeof(SysMonData)));
            Console.WriteLine("SizeOf(ConfigData) = {0}", Marshal.SizeOf(typeof(ConfigData)));
            Console.WriteLine("SizeOf(EEPROMData) = {0}", Marshal.SizeOf(typeof(EEPROMData)));
            Console.WriteLine("Done.");
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

        void FillMessage(string msg)
        {
            string[] lines = new string[tbxMessage.Lines.Length + 1];
            Array.Copy(tbxMessage.Lines, lines, tbxMessage.Lines.Length);
            lines[lines.Length - 1] = msg;
            tbxMessage.Lines = lines;
        }

        void board_OnTextReceived(object sender, string e)
        {
            try
            {
                this.Invoke(msgHandler, e);
            }catch(Exception ex)
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

        private void loadConfig(ConfigData e)
        {
            mConfigs = e;

            cfgManualAdj.Value = e.ManualAdjust;
            cfgWarmupTime.Value = e.WarmUpTime;
            cfgWarmupRPM.Value = e.WarmUpRPM;
            cfgRevPerPulse.Value = e.RevPerPulse;

            cfgRPMCount.Value = e.RPMCount;
            cfgRPMStart.Value = e.RPMStart;
            cfgRPMEnd.Value = e.RPMEnd;
            cfgRPMAccAdj.Value = e.RPMAdjust;
            cfgRPMAdjStep.Value = e.RPMAdjustStep;

            cfgLoadCount.Value = e.MAPCount;
            cfgLoadStart.Value = e.MAPStart;
            cfgLoadEnd.Value = e.MAPEnd;
            cfgLoadAccAdj.Value = e.MAPAdjust;
            cfgLoadAdjStep.Value = e.MAPAdjustStep;
        }

        void loadMonitoringInfo(SysMonData sysMon)
        {
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
        }

        private void btnMapping_Click(object sender, EventArgs e)
        {
        }

        private void btnAcceleration_Click(object sender, EventArgs e)
        {
        }

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
        }

        private void btnload_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnPort_Click(object sender, EventArgs e)
        {

        }

        private void createMapping(ConfigData config)
        {
            DataTable dt = new DataTable();
            int rpmCount = config.RPMCount;
            int rpmStart = config.RPMStart;
            int rpmEnd = config.RPMEnd;
            int rpmStep = (rpmEnd - rpmStart) / rpmCount;

            int mapCount = config.MAPCount;
            int mapStart = config.MAPStart;
            int mapEnd = config.MAPEnd;
            int mapStep = (mapEnd - mapStart) / mapCount;

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

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                cboPorts.Items.AddRange(SerialPort.GetPortNames());
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (board.IsOpen)
                {
                    board.DiscardInBuffer();
                    board.DiscardOutBuffer();
                    board.Close();

                    btnConnect.Text = "Connect";
                }
                else
                {
                    board.PortName = cboPorts.Text;
                    board.Open();
                    board.DiscardInBuffer();
                    board.DiscardOutBuffer();

                    // send read config command on connect to board
                    //board.SendCommand(CommandCodes.CMD_READ_CONFIGS);

                    btnConnect.Text = "Disconnect";
                }

            }catch(Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void ShowErrorDialog(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error Dialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtCmdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    board.SendCommand(txtCmdText.Text);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void infoCtrl1_Load(object sender, EventArgs e)
        {
                    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void configCtrl10_Load(object sender, EventArgs e)
        {

        }

        private void configCtrl2_Load(object sender, EventArgs e)
        {

        }

        private void cfgGraphXCount_OnValueChanged(object sender, EventArgs e)
        {
        }

        private void cfgGraphYCount_OnValueChanged(object sender, EventArgs e)
        {
        }
    }
}
