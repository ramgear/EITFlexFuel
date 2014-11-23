namespace EITFlex
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpSysInfo = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendCmd = new System.Windows.Forms.Button();
            this.txtCmdText = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMonitoring = new System.Windows.Forms.Button();
            this.btnAcceleration = new System.Windows.Forms.Button();
            this.btnMapping = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpSetting = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tpInjectors = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cfgRevPerPulse = new EITFlex.Controls.ConfigCtrl();
            this.cfgWarmupRPM = new EITFlex.Controls.ConfigCtrl();
            this.cfgWarmupTime = new EITFlex.Controls.ConfigCtrl();
            this.cfgLoadAccAdj = new EITFlex.Controls.ConfigCtrl();
            this.cfgRPMAccAdj = new EITFlex.Controls.ConfigCtrl();
            this.cfgManualAdj = new EITFlex.Controls.ConfigCtrl();
            this.cfgLoadAdjStep = new EITFlex.Controls.ConfigCtrl();
            this.cfgLoadStart = new EITFlex.Controls.ConfigCtrl();
            this.cfgLoadEnd = new EITFlex.Controls.ConfigCtrl();
            this.cfgLoadCount = new EITFlex.Controls.ConfigCtrl();
            this.cfgRPMAdjStep = new EITFlex.Controls.ConfigCtrl();
            this.cfgRPMEnd = new EITFlex.Controls.ConfigCtrl();
            this.cfgRPMStart = new EITFlex.Controls.ConfigCtrl();
            this.cfgRPMCount = new EITFlex.Controls.ConfigCtrl();
            this.tcMain.SuspendLayout();
            this.tpSysInfo.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpSetting.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpSysInfo);
            this.tcMain.Controls.Add(this.tpSetting);
            this.tcMain.Controls.Add(this.tpInjectors);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1362, 741);
            this.tcMain.TabIndex = 0;
            // 
            // tpSysInfo
            // 
            this.tpSysInfo.BackColor = System.Drawing.Color.White;
            this.tpSysInfo.Controls.Add(this.groupBox7);
            this.tpSysInfo.Controls.Add(this.groupBox6);
            this.tpSysInfo.Location = new System.Drawing.Point(4, 25);
            this.tpSysInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tpSysInfo.Name = "tpSysInfo";
            this.tpSysInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tpSysInfo.Size = new System.Drawing.Size(1354, 712);
            this.tpSysInfo.TabIndex = 0;
            this.tpSysInfo.Text = "System Settings:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbxMessage);
            this.groupBox7.Controls.Add(this.panel1);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(596, 4);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(754, 704);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Message:";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMessage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMessage.Location = new System.Drawing.Point(4, 60);
            this.tbxMessage.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.ReadOnly = true;
            this.tbxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMessage.Size = new System.Drawing.Size(746, 640);
            this.tbxMessage.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSendCmd);
            this.panel1.Controls.Add(this.txtCmdText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 41);
            this.panel1.TabIndex = 1;
            // 
            // btnSendCmd
            // 
            this.btnSendCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendCmd.Location = new System.Drawing.Point(642, 4);
            this.btnSendCmd.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendCmd.Name = "btnSendCmd";
            this.btnSendCmd.Size = new System.Drawing.Size(100, 28);
            this.btnSendCmd.TabIndex = 1;
            this.btnSendCmd.Text = "Send";
            this.btnSendCmd.UseVisualStyleBackColor = true;
            // 
            // txtCmdText
            // 
            this.txtCmdText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCmdText.Location = new System.Drawing.Point(16, 7);
            this.txtCmdText.Margin = new System.Windows.Forms.Padding(4);
            this.txtCmdText.Name = "txtCmdText";
            this.txtCmdText.Size = new System.Drawing.Size(617, 22);
            this.txtCmdText.TabIndex = 0;
            this.txtCmdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCmdText_KeyPress);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.btnMonitoring);
            this.groupBox6.Controls.Add(this.btnAcceleration);
            this.groupBox6.Controls.Add(this.btnMapping);
            this.groupBox6.Controls.Add(this.btnEnable);
            this.groupBox6.Controls.Add(this.cfgRevPerPulse);
            this.groupBox6.Controls.Add(this.cfgWarmupRPM);
            this.groupBox6.Controls.Add(this.cfgWarmupTime);
            this.groupBox6.Controls.Add(this.cfgLoadAccAdj);
            this.groupBox6.Controls.Add(this.cfgRPMAccAdj);
            this.groupBox6.Controls.Add(this.cfgManualAdj);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox6.Location = new System.Drawing.Point(4, 4);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(592, 704);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Settings:";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 253);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 51);
            this.button1.TabIndex = 25;
            this.button1.Text = "Load Acc";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMonitoring
            // 
            this.btnMonitoring.Location = new System.Drawing.Point(499, 253);
            this.btnMonitoring.Margin = new System.Windows.Forms.Padding(4);
            this.btnMonitoring.Name = "btnMonitoring";
            this.btnMonitoring.Size = new System.Drawing.Size(79, 51);
            this.btnMonitoring.TabIndex = 24;
            this.btnMonitoring.Text = "Monitoring";
            this.btnMonitoring.UseVisualStyleBackColor = true;
            // 
            // btnAcceleration
            // 
            this.btnAcceleration.Location = new System.Drawing.Point(255, 253);
            this.btnAcceleration.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcceleration.Name = "btnAcceleration";
            this.btnAcceleration.Size = new System.Drawing.Size(79, 51);
            this.btnAcceleration.TabIndex = 23;
            this.btnAcceleration.Text = "RPM Acc";
            this.btnAcceleration.UseVisualStyleBackColor = true;
            // 
            // btnMapping
            // 
            this.btnMapping.Location = new System.Drawing.Point(133, 253);
            this.btnMapping.Margin = new System.Windows.Forms.Padding(4);
            this.btnMapping.Name = "btnMapping";
            this.btnMapping.Size = new System.Drawing.Size(79, 51);
            this.btnMapping.TabIndex = 22;
            this.btnMapping.Text = "Mapping";
            this.btnMapping.UseVisualStyleBackColor = true;
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(11, 253);
            this.btnEnable.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(79, 51);
            this.btnEnable.TabIndex = 21;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.textBox1);
            this.groupBox8.Controls.Add(this.cboPorts);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.btnConnect);
            this.groupBox8.Location = new System.Drawing.Point(11, 155);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(547, 68);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Serial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Baudrate:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(75, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "115200";
            // 
            // cboPorts
            // 
            this.cboPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(67, 27);
            this.cboPorts.Margin = new System.Windows.Forms.Padding(4);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(160, 24);
            this.cboPorts.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 31);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 16);
            this.label19.TabIndex = 1;
            this.label19.Text = "Port:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(437, 25);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 28);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(139, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label2.Size = new System.Drawing.Size(419, 64);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome to E.I.T. world.\r\n\r\n Version: 1.0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(141, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "E.I.T. Company Limited.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EITFlex.Properties.Resources.download;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tpSetting
            // 
            this.tpSetting.Controls.Add(this.groupBox2);
            this.tpSetting.Controls.Add(this.groupBox1);
            this.tpSetting.Location = new System.Drawing.Point(4, 25);
            this.tpSetting.Margin = new System.Windows.Forms.Padding(4);
            this.tpSetting.Name = "tpSetting";
            this.tpSetting.Padding = new System.Windows.Forms.Padding(4);
            this.tpSetting.Size = new System.Drawing.Size(1354, 712);
            this.tpSetting.TabIndex = 1;
            this.tpSetting.Text = "Setting & Monitoring";
            this.tpSetting.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 198);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1346, 510);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fuel Mapping:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1338, 487);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cfgLoadAdjStep);
            this.groupBox1.Controls.Add(this.cfgLoadStart);
            this.groupBox1.Controls.Add(this.cfgLoadEnd);
            this.groupBox1.Controls.Add(this.cfgLoadCount);
            this.groupBox1.Controls.Add(this.cfgRPMAdjStep);
            this.groupBox1.Controls.Add(this.cfgRPMEnd);
            this.groupBox1.Controls.Add(this.cfgRPMStart);
            this.groupBox1.Controls.Add(this.cfgRPMCount);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1346, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuel Mapping Config::";
            // 
            // tpInjectors
            // 
            this.tpInjectors.Location = new System.Drawing.Point(4, 25);
            this.tpInjectors.Name = "tpInjectors";
            this.tpInjectors.Padding = new System.Windows.Forms.Padding(3);
            this.tpInjectors.Size = new System.Drawing.Size(1354, 712);
            this.tpInjectors.TabIndex = 2;
            this.tpInjectors.Text = "Injectors";
            this.tpInjectors.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cfgRevPerPulse
            // 
            this.cfgRevPerPulse.Location = new System.Drawing.Point(260, 493);
            this.cfgRevPerPulse.Margin = new System.Windows.Forms.Padding(5);
            this.cfgRevPerPulse.Max = 100;
            this.cfgRevPerPulse.Min = 0;
            this.cfgRevPerPulse.Name = "cfgRevPerPulse";
            this.cfgRevPerPulse.Size = new System.Drawing.Size(187, 55);
            this.cfgRevPerPulse.TabIndex = 12;
            this.cfgRevPerPulse.Title = "Rev/Pulse:";
            this.cfgRevPerPulse.Unit = "";
            this.cfgRevPerPulse.Value = 0;
            // 
            // cfgWarmupRPM
            // 
            this.cfgWarmupRPM.Location = new System.Drawing.Point(260, 420);
            this.cfgWarmupRPM.Margin = new System.Windows.Forms.Padding(5);
            this.cfgWarmupRPM.Max = 100;
            this.cfgWarmupRPM.Min = 0;
            this.cfgWarmupRPM.Name = "cfgWarmupRPM";
            this.cfgWarmupRPM.Size = new System.Drawing.Size(187, 55);
            this.cfgWarmupRPM.TabIndex = 11;
            this.cfgWarmupRPM.Title = "Warmup RPM";
            this.cfgWarmupRPM.Unit = "RPM";
            this.cfgWarmupRPM.Value = 0;
            // 
            // cfgWarmupTime
            // 
            this.cfgWarmupTime.Location = new System.Drawing.Point(260, 347);
            this.cfgWarmupTime.Margin = new System.Windows.Forms.Padding(5);
            this.cfgWarmupTime.Max = 100;
            this.cfgWarmupTime.Min = 0;
            this.cfgWarmupTime.Name = "cfgWarmupTime";
            this.cfgWarmupTime.Size = new System.Drawing.Size(187, 55);
            this.cfgWarmupTime.TabIndex = 10;
            this.cfgWarmupTime.Title = "Warmup Time:";
            this.cfgWarmupTime.Unit = "sec";
            this.cfgWarmupTime.Value = 0;
            // 
            // cfgLoadAccAdj
            // 
            this.cfgLoadAccAdj.Location = new System.Drawing.Point(51, 493);
            this.cfgLoadAccAdj.Margin = new System.Windows.Forms.Padding(5);
            this.cfgLoadAccAdj.Max = 100;
            this.cfgLoadAccAdj.Min = 0;
            this.cfgLoadAccAdj.Name = "cfgLoadAccAdj";
            this.cfgLoadAccAdj.Size = new System.Drawing.Size(187, 55);
            this.cfgLoadAccAdj.TabIndex = 9;
            this.cfgLoadAccAdj.Title = "Load Acc Adj:";
            this.cfgLoadAccAdj.Unit = "%";
            this.cfgLoadAccAdj.Value = 0;
            // 
            // cfgRPMAccAdj
            // 
            this.cfgRPMAccAdj.Location = new System.Drawing.Point(51, 420);
            this.cfgRPMAccAdj.Margin = new System.Windows.Forms.Padding(5);
            this.cfgRPMAccAdj.Max = 100;
            this.cfgRPMAccAdj.Min = 0;
            this.cfgRPMAccAdj.Name = "cfgRPMAccAdj";
            this.cfgRPMAccAdj.Size = new System.Drawing.Size(187, 55);
            this.cfgRPMAccAdj.TabIndex = 8;
            this.cfgRPMAccAdj.Title = "RPM Acc Adj:";
            this.cfgRPMAccAdj.Unit = "%";
            this.cfgRPMAccAdj.Value = 0;
            this.cfgRPMAccAdj.Load += new System.EventHandler(this.configCtrl2_Load);
            // 
            // cfgManualAdj
            // 
            this.cfgManualAdj.Location = new System.Drawing.Point(51, 347);
            this.cfgManualAdj.Margin = new System.Windows.Forms.Padding(4);
            this.cfgManualAdj.Max = 100;
            this.cfgManualAdj.Min = 0;
            this.cfgManualAdj.Name = "cfgManualAdj";
            this.cfgManualAdj.Size = new System.Drawing.Size(187, 55);
            this.cfgManualAdj.TabIndex = 7;
            this.cfgManualAdj.Title = "Manual Adj:";
            this.cfgManualAdj.Unit = "%";
            this.cfgManualAdj.Value = 0;
            // 
            // cfgLoadAdjStep
            // 
            this.cfgLoadAdjStep.BackColor = System.Drawing.Color.White;
            this.cfgLoadAdjStep.Location = new System.Drawing.Point(626, 106);
            this.cfgLoadAdjStep.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.cfgLoadAdjStep.Max = 100;
            this.cfgLoadAdjStep.Min = 0;
            this.cfgLoadAdjStep.Name = "cfgLoadAdjStep";
            this.cfgLoadAdjStep.Size = new System.Drawing.Size(187, 55);
            this.cfgLoadAdjStep.TabIndex = 28;
            this.cfgLoadAdjStep.Title = "Load Adj Step:";
            this.cfgLoadAdjStep.Unit = "%";
            this.cfgLoadAdjStep.Value = 0;
            // 
            // cfgLoadStart
            // 
            this.cfgLoadStart.BackColor = System.Drawing.Color.White;
            this.cfgLoadStart.Location = new System.Drawing.Point(216, 106);
            this.cfgLoadStart.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.cfgLoadStart.Max = 100;
            this.cfgLoadStart.Min = 0;
            this.cfgLoadStart.Name = "cfgLoadStart";
            this.cfgLoadStart.Size = new System.Drawing.Size(187, 55);
            this.cfgLoadStart.TabIndex = 27;
            this.cfgLoadStart.Title = "Load Start:";
            this.cfgLoadStart.Unit = "%";
            this.cfgLoadStart.Value = 0;
            // 
            // cfgLoadEnd
            // 
            this.cfgLoadEnd.BackColor = System.Drawing.Color.White;
            this.cfgLoadEnd.Location = new System.Drawing.Point(421, 106);
            this.cfgLoadEnd.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.cfgLoadEnd.Max = 100;
            this.cfgLoadEnd.Min = 0;
            this.cfgLoadEnd.Name = "cfgLoadEnd";
            this.cfgLoadEnd.Size = new System.Drawing.Size(187, 55);
            this.cfgLoadEnd.TabIndex = 26;
            this.cfgLoadEnd.Title = "Load End:";
            this.cfgLoadEnd.Unit = "%";
            this.cfgLoadEnd.Value = 0;
            // 
            // cfgLoadCount
            // 
            this.cfgLoadCount.BackColor = System.Drawing.Color.White;
            this.cfgLoadCount.Location = new System.Drawing.Point(13, 106);
            this.cfgLoadCount.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.cfgLoadCount.Max = 100;
            this.cfgLoadCount.Min = 0;
            this.cfgLoadCount.Name = "cfgLoadCount";
            this.cfgLoadCount.Size = new System.Drawing.Size(187, 55);
            this.cfgLoadCount.TabIndex = 25;
            this.cfgLoadCount.Title = "Load Count:";
            this.cfgLoadCount.Unit = "";
            this.cfgLoadCount.Value = 0;
            // 
            // cfgRPMAdjStep
            // 
            this.cfgRPMAdjStep.BackColor = System.Drawing.Color.White;
            this.cfgRPMAdjStep.Location = new System.Drawing.Point(626, 26);
            this.cfgRPMAdjStep.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.cfgRPMAdjStep.Max = 100;
            this.cfgRPMAdjStep.Min = 0;
            this.cfgRPMAdjStep.Name = "cfgRPMAdjStep";
            this.cfgRPMAdjStep.Size = new System.Drawing.Size(187, 55);
            this.cfgRPMAdjStep.TabIndex = 24;
            this.cfgRPMAdjStep.Title = "RPM Adj Step:";
            this.cfgRPMAdjStep.Unit = "RPM";
            this.cfgRPMAdjStep.Value = 0;
            // 
            // cfgRPMEnd
            // 
            this.cfgRPMEnd.BackColor = System.Drawing.Color.White;
            this.cfgRPMEnd.Location = new System.Drawing.Point(421, 26);
            this.cfgRPMEnd.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.cfgRPMEnd.Max = 100;
            this.cfgRPMEnd.Min = 0;
            this.cfgRPMEnd.Name = "cfgRPMEnd";
            this.cfgRPMEnd.Size = new System.Drawing.Size(187, 55);
            this.cfgRPMEnd.TabIndex = 23;
            this.cfgRPMEnd.Title = "RPM End:";
            this.cfgRPMEnd.Unit = "RPM";
            this.cfgRPMEnd.Value = 0;
            // 
            // cfgRPMStart
            // 
            this.cfgRPMStart.BackColor = System.Drawing.Color.White;
            this.cfgRPMStart.Location = new System.Drawing.Point(216, 26);
            this.cfgRPMStart.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.cfgRPMStart.Max = 100;
            this.cfgRPMStart.Min = 0;
            this.cfgRPMStart.Name = "cfgRPMStart";
            this.cfgRPMStart.Size = new System.Drawing.Size(187, 55);
            this.cfgRPMStart.TabIndex = 22;
            this.cfgRPMStart.Title = "RPM Start:";
            this.cfgRPMStart.Unit = "RPM";
            this.cfgRPMStart.Value = 0;
            // 
            // cfgRPMCount
            // 
            this.cfgRPMCount.BackColor = System.Drawing.Color.White;
            this.cfgRPMCount.Location = new System.Drawing.Point(13, 25);
            this.cfgRPMCount.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cfgRPMCount.Max = 100;
            this.cfgRPMCount.Min = 0;
            this.cfgRPMCount.Name = "cfgRPMCount";
            this.cfgRPMCount.Size = new System.Drawing.Size(187, 55);
            this.cfgRPMCount.TabIndex = 21;
            this.cfgRPMCount.Title = "RPM Count:";
            this.cfgRPMCount.Unit = "";
            this.cfgRPMCount.Value = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "EIT Flex Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tcMain.ResumeLayout(false);
            this.tpSysInfo.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpSetting.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpSysInfo;
        private System.Windows.Forms.TabPage tpSetting;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSendCmd;
        private System.Windows.Forms.TextBox txtCmdText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private Controls.ConfigCtrl cfgManualAdj;
        private Controls.ConfigCtrl cfgRevPerPulse;
        private Controls.ConfigCtrl cfgWarmupRPM;
        private Controls.ConfigCtrl cfgWarmupTime;
        private Controls.ConfigCtrl cfgLoadAccAdj;
        private Controls.ConfigCtrl cfgRPMAccAdj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMonitoring;
        private System.Windows.Forms.Button btnAcceleration;
        private System.Windows.Forms.Button btnMapping;
        private System.Windows.Forms.Button btnEnable;
        private Controls.ConfigCtrl cfgLoadAdjStep;
        private Controls.ConfigCtrl cfgLoadStart;
        private Controls.ConfigCtrl cfgLoadEnd;
        private Controls.ConfigCtrl cfgLoadCount;
        private Controls.ConfigCtrl cfgRPMAdjStep;
        private Controls.ConfigCtrl cfgRPMEnd;
        private Controls.ConfigCtrl cfgRPMStart;
        private Controls.ConfigCtrl cfgRPMCount;
        private System.Windows.Forms.TabPage tpInjectors;
    }
}

