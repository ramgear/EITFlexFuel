﻿namespace EITFlex
{
    partial class FrmMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbCommunication = new EITFlex.Controls.TabButton();
            this.tbFuelMap = new EITFlex.Controls.TabButton();
            this.tbSettings = new EITFlex.Controls.TabButton();
            this.tbInfo = new EITFlex.Controls.TabButton();
            this.headerControl2 = new EITFlex.Controls.HeaderControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.customGroupBox1 = new EITFlex.Controls.CustomGroupBox();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCommandText = new System.Windows.Forms.TextBox();
            this.btnSendCmd = new EITFlex.Controls.CustomButton();
            this.btnClearMessage = new EITFlex.Controls.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.scLoadAcc = new EITFlex.Controls.StatusControl();
            this.scLoad = new EITFlex.Controls.StatusControl();
            this.btnRefresh = new EITFlex.Controls.CustomButton();
            this.scRPMAcc = new EITFlex.Controls.StatusControl();
            this.scRPM = new EITFlex.Controls.StatusControl();
            this.scRPMDutyCycle = new EITFlex.Controls.StatusControl();
            this.scFuelAdjust = new EITFlex.Controls.StatusControl();
            this.headerControl1 = new EITFlex.Controls.HeaderControl();
            this.tpSetting = new System.Windows.Forms.TabPage();
            this.swInjMon = new EITFlex.Controls.SwitchControl();
            this.swSysMon = new EITFlex.Controls.SwitchControl();
            this.swLoadAcc = new EITFlex.Controls.SwitchControl();
            this.swRPMAcc = new EITFlex.Controls.SwitchControl();
            this.swFuelMap = new EITFlex.Controls.SwitchControl();
            this.swFeatures = new EITFlex.Controls.SwitchControl();
            this.headerControl3 = new EITFlex.Controls.HeaderControl();
            this.tpFuelMap = new System.Windows.Forms.TabPage();
            this.gpFuelMapTable = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpFuelMapSetting = new System.Windows.Forms.GroupBox();
            this.btnFuelMapRead = new System.Windows.Forms.Button();
            this.btnFuelMapCal = new EITFlex.Controls.CustomButton();
            this.numLoadEnd = new System.Windows.Forms.NumericUpDown();
            this.numLoadStep = new System.Windows.Forms.NumericUpDown();
            this.numLoadStart = new System.Windows.Forms.NumericUpDown();
            this.numRPMEnd = new System.Windows.Forms.NumericUpDown();
            this.numRPMStep = new System.Windows.Forms.NumericUpDown();
            this.numRPMStart = new System.Windows.Forms.NumericUpDown();
            this.btnFuelMapApply = new EITFlex.Controls.CustomButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.headerControl4 = new EITFlex.Controls.HeaderControl();
            this.tpComm = new System.Windows.Forms.TabPage();
            this.btnSerialDisconnect = new EITFlex.Controls.CustomButton();
            this.btnSerialConnect = new EITFlex.Controls.CustomButton();
            this.gbSerialSpeed = new EITFlex.Controls.CustomGroupBox();
            this.gbSerialport = new EITFlex.Controls.CustomGroupBox();
            this.headerControl5 = new EITFlex.Controls.HeaderControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.customGroupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpSetting.SuspendLayout();
            this.tpFuelMap.SuspendLayout();
            this.gpFuelMapTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpFuelMapSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLoadEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoadStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoadStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRPMEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRPMStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRPMStart)).BeginInit();
            this.tpComm.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "setting-icon-1105214514.png");
            this.imageList1.Images.SetKeyName(1, "diagnostic-icon.png");
            this.imageList1.Images.SetKeyName(2, "table-icon.jpg");
            this.imageList1.Images.SetKeyName(3, "bluetooth-icon-square-power-off.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel1.Controls.Add(this.tbCommunication);
            this.splitContainer1.Panel1.Controls.Add(this.tbFuelMap);
            this.splitContainer1.Panel1.Controls.Add(this.tbSettings);
            this.splitContainer1.Panel1.Controls.Add(this.tbInfo);
            this.splitContainer1.Panel1.Controls.Add(this.headerControl2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tcMain);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 561);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 1;
            // 
            // tbCommunication
            // 
            this.tbCommunication.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbCommunication.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCommunication.FlatAppearance.BorderSize = 0;
            this.tbCommunication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbCommunication.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCommunication.ForeColor = System.Drawing.Color.White;
            this.tbCommunication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCommunication.ImageIndex = 3;
            this.tbCommunication.ImageList = this.imageList1;
            this.tbCommunication.Location = new System.Drawing.Point(0, 347);
            this.tbCommunication.Name = "tbCommunication";
            this.tbCommunication.NormalColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbCommunication.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tbCommunication.Selected = false;
            this.tbCommunication.SelectedColor = System.Drawing.Color.LimeGreen;
            this.tbCommunication.Size = new System.Drawing.Size(210, 64);
            this.tbCommunication.TabIndex = 9;
            this.tbCommunication.Text = "Communication";
            this.tbCommunication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCommunication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tbCommunication.UseVisualStyleBackColor = false;
            // 
            // tbFuelMap
            // 
            this.tbFuelMap.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbFuelMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFuelMap.FlatAppearance.BorderSize = 0;
            this.tbFuelMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbFuelMap.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFuelMap.ForeColor = System.Drawing.Color.White;
            this.tbFuelMap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbFuelMap.ImageIndex = 2;
            this.tbFuelMap.ImageList = this.imageList1;
            this.tbFuelMap.Location = new System.Drawing.Point(0, 283);
            this.tbFuelMap.Name = "tbFuelMap";
            this.tbFuelMap.NormalColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbFuelMap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tbFuelMap.Selected = false;
            this.tbFuelMap.SelectedColor = System.Drawing.Color.LimeGreen;
            this.tbFuelMap.Size = new System.Drawing.Size(210, 64);
            this.tbFuelMap.TabIndex = 8;
            this.tbFuelMap.Text = "Fuel Map";
            this.tbFuelMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbFuelMap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tbFuelMap.UseVisualStyleBackColor = false;
            // 
            // tbSettings
            // 
            this.tbSettings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSettings.FlatAppearance.BorderSize = 0;
            this.tbSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbSettings.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSettings.ForeColor = System.Drawing.Color.White;
            this.tbSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSettings.ImageIndex = 0;
            this.tbSettings.ImageList = this.imageList1;
            this.tbSettings.Location = new System.Drawing.Point(0, 219);
            this.tbSettings.Name = "tbSettings";
            this.tbSettings.NormalColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tbSettings.Selected = false;
            this.tbSettings.SelectedColor = System.Drawing.Color.LimeGreen;
            this.tbSettings.Size = new System.Drawing.Size(210, 64);
            this.tbSettings.TabIndex = 5;
            this.tbSettings.Text = "Settings";
            this.tbSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tbSettings.UseVisualStyleBackColor = false;
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbInfo.FlatAppearance.BorderSize = 0;
            this.tbInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbInfo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInfo.ForeColor = System.Drawing.Color.White;
            this.tbInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbInfo.ImageIndex = 1;
            this.tbInfo.ImageList = this.imageList1;
            this.tbInfo.Location = new System.Drawing.Point(0, 155);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.NormalColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tbInfo.Selected = false;
            this.tbInfo.SelectedColor = System.Drawing.Color.LimeGreen;
            this.tbInfo.Size = new System.Drawing.Size(210, 64);
            this.tbInfo.TabIndex = 4;
            this.tbInfo.Text = "Device Info";
            this.tbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tbInfo.UseVisualStyleBackColor = false;
            // 
            // headerControl2
            // 
            this.headerControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerControl2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headerControl2.HeaderText = "Menu";
            this.headerControl2.LineColor = System.Drawing.Color.Silver;
            this.headerControl2.Location = new System.Drawing.Point(0, 110);
            this.headerControl2.Name = "headerControl2";
            this.headerControl2.Size = new System.Drawing.Size(210, 45);
            this.headerControl2.TabIndex = 7;
            this.headerControl2.TextColor = System.Drawing.SystemColors.AppWorkspace;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 110);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(0, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "Embedded Innovation Technology";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "E.I.T.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpInfo);
            this.tcMain.Controls.Add(this.tpSetting);
            this.tcMain.Controls.Add(this.tpFuelMap);
            this.tcMain.Controls.Add(this.tpComm);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.ItemSize = new System.Drawing.Size(150, 48);
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(794, 561);
            this.tcMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcMain.TabIndex = 0;
            // 
            // tpInfo
            // 
            this.tpInfo.BackColor = System.Drawing.Color.Transparent;
            this.tpInfo.Controls.Add(this.customGroupBox1);
            this.tpInfo.Controls.Add(this.panel4);
            this.tpInfo.Controls.Add(this.panel2);
            this.tpInfo.Controls.Add(this.headerControl1);
            this.tpInfo.Location = new System.Drawing.Point(4, 52);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tpInfo.Size = new System.Drawing.Size(786, 505);
            this.tpInfo.TabIndex = 0;
            this.tpInfo.Text = "Information";
            // 
            // customGroupBox1
            // 
            this.customGroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.customGroupBox1.BorderColor = System.Drawing.Color.Silver;
            this.customGroupBox1.Controls.Add(this.tbxMessage);
            this.customGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.customGroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.customGroupBox1.Location = new System.Drawing.Point(426, 73);
            this.customGroupBox1.Name = "customGroupBox1";
            this.customGroupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.customGroupBox1.Size = new System.Drawing.Size(357, 429);
            this.customGroupBox1.TabIndex = 7;
            this.customGroupBox1.TabStop = false;
            this.customGroupBox1.Text = "System Message:";
            // 
            // tbxMessage
            // 
            this.tbxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMessage.Location = new System.Drawing.Point(5, 20);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.ReadOnly = true;
            this.tbxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMessage.Size = new System.Drawing.Size(347, 404);
            this.tbxMessage.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtCommandText);
            this.panel4.Controls.Add(this.btnSendCmd);
            this.panel4.Controls.Add(this.btnClearMessage);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(426, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 28);
            this.panel4.TabIndex = 6;
            // 
            // txtCommandText
            // 
            this.txtCommandText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCommandText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtCommandText.Location = new System.Drawing.Point(0, 0);
            this.txtCommandText.Multiline = true;
            this.txtCommandText.Name = "txtCommandText";
            this.txtCommandText.Size = new System.Drawing.Size(207, 28);
            this.txtCommandText.TabIndex = 3;
            this.txtCommandText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCmdText_KeyPress);
            // 
            // btnSendCmd
            // 
            this.btnSendCmd.Changed = false;
            this.btnSendCmd.ChangeImage = null;
            this.btnSendCmd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendCmd.Location = new System.Drawing.Point(207, 0);
            this.btnSendCmd.Name = "btnSendCmd";
            this.btnSendCmd.Size = new System.Drawing.Size(75, 28);
            this.btnSendCmd.TabIndex = 1;
            this.btnSendCmd.Text = "Send Cmd";
            this.btnSendCmd.UseVisualStyleBackColor = true;
            this.btnSendCmd.Click += new System.EventHandler(this.btnSendCmd_Click);
            // 
            // btnClearMessage
            // 
            this.btnClearMessage.Changed = false;
            this.btnClearMessage.ChangeImage = null;
            this.btnClearMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearMessage.Location = new System.Drawing.Point(282, 0);
            this.btnClearMessage.Name = "btnClearMessage";
            this.btnClearMessage.Size = new System.Drawing.Size(75, 28);
            this.btnClearMessage.TabIndex = 2;
            this.btnClearMessage.Text = "Clear";
            this.btnClearMessage.UseVisualStyleBackColor = true;
            this.btnClearMessage.Click += new System.EventHandler(this.btnClearMessage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.scLoadAcc);
            this.panel2.Controls.Add(this.scLoad);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.scRPMAcc);
            this.panel2.Controls.Add(this.scRPM);
            this.panel2.Controls.Add(this.scRPMDutyCycle);
            this.panel2.Controls.Add(this.scFuelAdjust);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 45);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel2.Size = new System.Drawing.Size(423, 457);
            this.panel2.TabIndex = 5;
            // 
            // scLoadAcc
            // 
            this.scLoadAcc.BackColor = System.Drawing.Color.Transparent;
            this.scLoadAcc.DetailText = "Load percent change per second.";
            this.scLoadAcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.scLoadAcc.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scLoadAcc.HeaderText = "Load Acceleration: ";
            this.scLoadAcc.Location = new System.Drawing.Point(0, 275);
            this.scLoadAcc.Maximum = 100;
            this.scLoadAcc.Minimum = 0;
            this.scLoadAcc.Name = "scLoadAcc";
            this.scLoadAcc.Padding = new System.Windows.Forms.Padding(5);
            this.scLoadAcc.Size = new System.Drawing.Size(413, 55);
            this.scLoadAcc.TabIndex = 4;
            this.scLoadAcc.Unit = " %/s";
            this.scLoadAcc.Value = 80;
            // 
            // scLoad
            // 
            this.scLoad.BackColor = System.Drawing.Color.Transparent;
            this.scLoad.DetailText = "Current load value.";
            this.scLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.scLoad.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scLoad.HeaderText = "Load: ";
            this.scLoad.Location = new System.Drawing.Point(0, 220);
            this.scLoad.Maximum = 100;
            this.scLoad.Minimum = 0;
            this.scLoad.Name = "scLoad";
            this.scLoad.Padding = new System.Windows.Forms.Padding(5);
            this.scLoad.Size = new System.Drawing.Size(413, 55);
            this.scLoad.TabIndex = 3;
            this.scLoad.Value = 80;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Changed = false;
            this.btnRefresh.ChangeImage = null;
            this.btnRefresh.Location = new System.Drawing.Point(89, 369);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 53);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // scRPMAcc
            // 
            this.scRPMAcc.BackColor = System.Drawing.Color.Transparent;
            this.scRPMAcc.DetailText = "RPM change per second.";
            this.scRPMAcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.scRPMAcc.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scRPMAcc.HeaderText = "RPM Acceleration: ";
            this.scRPMAcc.Location = new System.Drawing.Point(0, 165);
            this.scRPMAcc.Maximum = 1000;
            this.scRPMAcc.Minimum = 0;
            this.scRPMAcc.Name = "scRPMAcc";
            this.scRPMAcc.Padding = new System.Windows.Forms.Padding(5);
            this.scRPMAcc.Size = new System.Drawing.Size(413, 55);
            this.scRPMAcc.TabIndex = 6;
            this.scRPMAcc.Unit = " RPM/s";
            this.scRPMAcc.Value = 200;
            // 
            // scRPM
            // 
            this.scRPM.BackColor = System.Drawing.Color.Transparent;
            this.scRPM.DetailText = "Current rotation per minute.";
            this.scRPM.Dock = System.Windows.Forms.DockStyle.Top;
            this.scRPM.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scRPM.HeaderText = "RPM: ";
            this.scRPM.Location = new System.Drawing.Point(0, 110);
            this.scRPM.Maximum = 4000;
            this.scRPM.Minimum = 0;
            this.scRPM.Name = "scRPM";
            this.scRPM.Padding = new System.Windows.Forms.Padding(5);
            this.scRPM.Size = new System.Drawing.Size(413, 55);
            this.scRPM.TabIndex = 5;
            this.scRPM.Unit = "";
            this.scRPM.Value = 2000;
            // 
            // scRPMDutyCycle
            // 
            this.scRPMDutyCycle.BackColor = System.Drawing.Color.Transparent;
            this.scRPMDutyCycle.DetailText = "Current injector duty cycle.";
            this.scRPMDutyCycle.Dock = System.Windows.Forms.DockStyle.Top;
            this.scRPMDutyCycle.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scRPMDutyCycle.HeaderText = "RPM Duty Cycle: ";
            this.scRPMDutyCycle.Location = new System.Drawing.Point(0, 55);
            this.scRPMDutyCycle.Maximum = 100;
            this.scRPMDutyCycle.Minimum = 0;
            this.scRPMDutyCycle.Name = "scRPMDutyCycle";
            this.scRPMDutyCycle.Padding = new System.Windows.Forms.Padding(5);
            this.scRPMDutyCycle.Size = new System.Drawing.Size(413, 55);
            this.scRPMDutyCycle.TabIndex = 0;
            this.scRPMDutyCycle.Value = 80;
            // 
            // scFuelAdjust
            // 
            this.scFuelAdjust.BackColor = System.Drawing.Color.Transparent;
            this.scFuelAdjust.DetailText = "Current fuel adjestment include manual, acceleration & mapping.";
            this.scFuelAdjust.Dock = System.Windows.Forms.DockStyle.Top;
            this.scFuelAdjust.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scFuelAdjust.HeaderText = "Fuel Adjustment: ";
            this.scFuelAdjust.Location = new System.Drawing.Point(0, 0);
            this.scFuelAdjust.Maximum = 35;
            this.scFuelAdjust.Minimum = 0;
            this.scFuelAdjust.Name = "scFuelAdjust";
            this.scFuelAdjust.Padding = new System.Windows.Forms.Padding(5);
            this.scFuelAdjust.Size = new System.Drawing.Size(413, 55);
            this.scFuelAdjust.TabIndex = 2;
            this.scFuelAdjust.Value = 25;
            // 
            // headerControl1
            // 
            this.headerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerControl1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.headerControl1.HeaderText = "Device Info:";
            this.headerControl1.LineColor = System.Drawing.Color.Silver;
            this.headerControl1.Location = new System.Drawing.Point(3, 10);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(780, 35);
            this.headerControl1.TabIndex = 8;
            this.headerControl1.TextColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // tpSetting
            // 
            this.tpSetting.BackColor = System.Drawing.Color.Transparent;
            this.tpSetting.Controls.Add(this.swInjMon);
            this.tpSetting.Controls.Add(this.swSysMon);
            this.tpSetting.Controls.Add(this.swLoadAcc);
            this.tpSetting.Controls.Add(this.swRPMAcc);
            this.tpSetting.Controls.Add(this.swFuelMap);
            this.tpSetting.Controls.Add(this.swFeatures);
            this.tpSetting.Controls.Add(this.headerControl3);
            this.tpSetting.Location = new System.Drawing.Point(4, 52);
            this.tpSetting.Name = "tpSetting";
            this.tpSetting.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tpSetting.Size = new System.Drawing.Size(786, 505);
            this.tpSetting.TabIndex = 1;
            this.tpSetting.Text = "Settings";
            // 
            // swInjMon
            // 
            this.swInjMon.Detial = "Enable/Disable  injector mornitoring to receive injector information to display i" +
                "n program.";
            this.swInjMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.swInjMon.HeaderText = "Injector Monitoring";
            this.swInjMon.Label1 = "label1";
            this.swInjMon.Label2 = "label2";
            this.swInjMon.Location = new System.Drawing.Point(3, 459);
            this.swInjMon.Maximum1 = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.swInjMon.Maximum2 = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.swInjMon.Minimum1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swInjMon.Minimum2 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swInjMon.Name = "swInjMon";
            this.swInjMon.ReadOnly = true;
            this.swInjMon.Size = new System.Drawing.Size(780, 61);
            this.swInjMon.Stat = false;
            this.swInjMon.TabIndex = 8;
            this.swInjMon.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swInjMon.Value2 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swInjMon.OnStatChanged += new System.EventHandler(this.swInjMon_OnStatChanged);
            // 
            // swSysMon
            // 
            this.swSysMon.Detial = "Enable/Disable  system mornitoring to receive data from device to display in prog" +
                "ram.";
            this.swSysMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.swSysMon.HeaderText = "System Monitoring";
            this.swSysMon.Label1 = "label1";
            this.swSysMon.Label2 = "label2";
            this.swSysMon.Location = new System.Drawing.Point(3, 404);
            this.swSysMon.Maximum1 = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.swSysMon.Maximum2 = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.swSysMon.Minimum1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swSysMon.Minimum2 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swSysMon.Name = "swSysMon";
            this.swSysMon.ReadOnly = true;
            this.swSysMon.Size = new System.Drawing.Size(780, 55);
            this.swSysMon.Stat = false;
            this.swSysMon.TabIndex = 7;
            this.swSysMon.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swSysMon.Value2 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swSysMon.OnStatChanged += new System.EventHandler(this.swSysMon_OnStatChanged);
            // 
            // swLoadAcc
            // 
            this.swLoadAcc.Detial = "Enable/Disable  fuel adjustment based on Load changed per second.";
            this.swLoadAcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.swLoadAcc.HeaderText = "Load Acceleration";
            this.swLoadAcc.Label1 = "Load Step ( 1 - 100 ) :";
            this.swLoadAcc.Label2 = "Fuel Adjust ( 0 - 5 % ) :";
            this.swLoadAcc.Location = new System.Drawing.Point(3, 314);
            this.swLoadAcc.Maximum1 = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.swLoadAcc.Maximum2 = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.swLoadAcc.Minimum1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swLoadAcc.Minimum2 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swLoadAcc.Name = "swLoadAcc";
            this.swLoadAcc.ReadOnly = true;
            this.swLoadAcc.Size = new System.Drawing.Size(780, 90);
            this.swLoadAcc.Stat = false;
            this.swLoadAcc.TabIndex = 6;
            this.swLoadAcc.Value1 = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.swLoadAcc.Value2 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swLoadAcc.OnSet += new System.EventHandler(this.swLoadAcc_OnSet);
            this.swLoadAcc.OnStatChanged += new System.EventHandler(this.swLoadAcc_OnStatChanged);
            // 
            // swRPMAcc
            // 
            this.swRPMAcc.Detial = "Enable/Disable  fuel adjustment based on RPM changed per second.";
            this.swRPMAcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.swRPMAcc.HeaderText = "RPM Acceleration";
            this.swRPMAcc.Label1 = "RPM Step ( 1 - 1000 ) :";
            this.swRPMAcc.Label2 = "Fuel Adjust ( 0 - 5 % ) :";
            this.swRPMAcc.Location = new System.Drawing.Point(3, 223);
            this.swRPMAcc.Maximum1 = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.swRPMAcc.Maximum2 = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.swRPMAcc.Minimum1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swRPMAcc.Minimum2 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swRPMAcc.Name = "swRPMAcc";
            this.swRPMAcc.ReadOnly = true;
            this.swRPMAcc.Size = new System.Drawing.Size(780, 91);
            this.swRPMAcc.Stat = false;
            this.swRPMAcc.TabIndex = 5;
            this.swRPMAcc.Value1 = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.swRPMAcc.Value2 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swRPMAcc.OnSet += new System.EventHandler(this.swRPMAcc_OnSet);
            this.swRPMAcc.OnStatChanged += new System.EventHandler(this.swRPMAcc_OnStatChanged);
            // 
            // swFuelMap
            // 
            this.swFuelMap.Detial = "Enable/Disable  fuel mapping table based on RPM and Load value for each time chec" +
                "king.";
            this.swFuelMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.swFuelMap.HeaderText = "Fuel Map";
            this.swFuelMap.Label1 = "RPM Count:";
            this.swFuelMap.Label2 = "Load Count:";
            this.swFuelMap.Location = new System.Drawing.Point(3, 135);
            this.swFuelMap.Maximum1 = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.swFuelMap.Maximum2 = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.swFuelMap.Minimum1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swFuelMap.Minimum2 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swFuelMap.Name = "swFuelMap";
            this.swFuelMap.ReadOnly = true;
            this.swFuelMap.Size = new System.Drawing.Size(780, 88);
            this.swFuelMap.Stat = false;
            this.swFuelMap.TabIndex = 4;
            this.swFuelMap.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swFuelMap.Value2 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swFuelMap.OnSet += new System.EventHandler(this.swFuelMap_OnSet);
            this.swFuelMap.OnStatChanged += new System.EventHandler(this.swFuelMap_OnStatChanged);
            // 
            // swFeatures
            // 
            this.swFeatures.Detial = "Enable/Disable  dependent features such as \"Fuel Map\", \"RPM Acceleration\" and \"Lo" +
                "ad Acceleration\".";
            this.swFeatures.Dock = System.Windows.Forms.DockStyle.Top;
            this.swFeatures.HeaderText = "Features";
            this.swFeatures.Label1 = "Maximum Adjust ( 0 - 35 % ):";
            this.swFeatures.Label2 = "Manual Adjust ( 0 - 35 % ):";
            this.swFeatures.Location = new System.Drawing.Point(3, 45);
            this.swFeatures.Maximum1 = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.swFeatures.Maximum2 = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.swFeatures.Minimum1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swFeatures.Minimum2 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swFeatures.Name = "swFeatures";
            this.swFeatures.ReadOnly = true;
            this.swFeatures.Size = new System.Drawing.Size(780, 90);
            this.swFeatures.Stat = false;
            this.swFeatures.TabIndex = 3;
            this.swFeatures.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swFeatures.Value2 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.swFeatures.OnSet += new System.EventHandler(this.swFeatures_OnSet);
            this.swFeatures.OnStatChanged += new System.EventHandler(this.swFeatures_OnStatChanged);
            // 
            // headerControl3
            // 
            this.headerControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerControl3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.headerControl3.HeaderText = "Settings:";
            this.headerControl3.LineColor = System.Drawing.Color.Silver;
            this.headerControl3.Location = new System.Drawing.Point(3, 10);
            this.headerControl3.Name = "headerControl3";
            this.headerControl3.Size = new System.Drawing.Size(780, 35);
            this.headerControl3.TabIndex = 2;
            this.headerControl3.TextColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // tpFuelMap
            // 
            this.tpFuelMap.Controls.Add(this.gpFuelMapTable);
            this.tpFuelMap.Controls.Add(this.gpFuelMapSetting);
            this.tpFuelMap.Controls.Add(this.headerControl4);
            this.tpFuelMap.Location = new System.Drawing.Point(4, 52);
            this.tpFuelMap.Name = "tpFuelMap";
            this.tpFuelMap.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tpFuelMap.Size = new System.Drawing.Size(786, 505);
            this.tpFuelMap.TabIndex = 2;
            this.tpFuelMap.Text = "Fuel Map";
            this.tpFuelMap.UseVisualStyleBackColor = true;
            // 
            // gpFuelMapTable
            // 
            this.gpFuelMapTable.Controls.Add(this.dataGridView1);
            this.gpFuelMapTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpFuelMapTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gpFuelMapTable.Location = new System.Drawing.Point(3, 167);
            this.gpFuelMapTable.Margin = new System.Windows.Forms.Padding(4);
            this.gpFuelMapTable.Name = "gpFuelMapTable";
            this.gpFuelMapTable.Padding = new System.Windows.Forms.Padding(4);
            this.gpFuelMapTable.Size = new System.Drawing.Size(780, 335);
            this.gpFuelMapTable.TabIndex = 5;
            this.gpFuelMapTable.TabStop = false;
            this.gpFuelMapTable.Text = "Fuel Mapping:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(772, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // gpFuelMapSetting
            // 
            this.gpFuelMapSetting.Controls.Add(this.btnFuelMapRead);
            this.gpFuelMapSetting.Controls.Add(this.btnFuelMapCal);
            this.gpFuelMapSetting.Controls.Add(this.numLoadEnd);
            this.gpFuelMapSetting.Controls.Add(this.numLoadStep);
            this.gpFuelMapSetting.Controls.Add(this.numLoadStart);
            this.gpFuelMapSetting.Controls.Add(this.numRPMEnd);
            this.gpFuelMapSetting.Controls.Add(this.numRPMStep);
            this.gpFuelMapSetting.Controls.Add(this.numRPMStart);
            this.gpFuelMapSetting.Controls.Add(this.btnFuelMapApply);
            this.gpFuelMapSetting.Controls.Add(this.label6);
            this.gpFuelMapSetting.Controls.Add(this.label7);
            this.gpFuelMapSetting.Controls.Add(this.label8);
            this.gpFuelMapSetting.Controls.Add(this.label5);
            this.gpFuelMapSetting.Controls.Add(this.label4);
            this.gpFuelMapSetting.Controls.Add(this.label3);
            this.gpFuelMapSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpFuelMapSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gpFuelMapSetting.Location = new System.Drawing.Point(3, 45);
            this.gpFuelMapSetting.Margin = new System.Windows.Forms.Padding(4);
            this.gpFuelMapSetting.Name = "gpFuelMapSetting";
            this.gpFuelMapSetting.Padding = new System.Windows.Forms.Padding(4);
            this.gpFuelMapSetting.Size = new System.Drawing.Size(780, 122);
            this.gpFuelMapSetting.TabIndex = 4;
            this.gpFuelMapSetting.TabStop = false;
            this.gpFuelMapSetting.Text = "Fuel Mapping Config::";
            // 
            // btnFuelMapRead
            // 
            this.btnFuelMapRead.Location = new System.Drawing.Point(553, 87);
            this.btnFuelMapRead.Name = "btnFuelMapRead";
            this.btnFuelMapRead.Size = new System.Drawing.Size(105, 31);
            this.btnFuelMapRead.TabIndex = 20;
            this.btnFuelMapRead.Text = "Read";
            this.btnFuelMapRead.UseVisualStyleBackColor = true;
            this.btnFuelMapRead.Click += new System.EventHandler(this.btnFuelMapRead_Click);
            // 
            // btnFuelMapCal
            // 
            this.btnFuelMapCal.Changed = false;
            this.btnFuelMapCal.ChangeImage = null;
            this.btnFuelMapCal.Location = new System.Drawing.Point(553, 51);
            this.btnFuelMapCal.Name = "btnFuelMapCal";
            this.btnFuelMapCal.Size = new System.Drawing.Size(105, 31);
            this.btnFuelMapCal.TabIndex = 19;
            this.btnFuelMapCal.Text = "Cal";
            this.btnFuelMapCal.UseVisualStyleBackColor = true;
            this.btnFuelMapCal.Click += new System.EventHandler(this.btnFuelMapCal_Click);
            // 
            // numLoadEnd
            // 
            this.numLoadEnd.DecimalPlaces = 1;
            this.numLoadEnd.Location = new System.Drawing.Point(370, 84);
            this.numLoadEnd.Name = "numLoadEnd";
            this.numLoadEnd.ReadOnly = true;
            this.numLoadEnd.Size = new System.Drawing.Size(120, 22);
            this.numLoadEnd.TabIndex = 18;
            // 
            // numLoadStep
            // 
            this.numLoadStep.DecimalPlaces = 1;
            this.numLoadStep.Location = new System.Drawing.Point(370, 57);
            this.numLoadStep.Name = "numLoadStep";
            this.numLoadStep.Size = new System.Drawing.Size(120, 22);
            this.numLoadStep.TabIndex = 17;
            // 
            // numLoadStart
            // 
            this.numLoadStart.DecimalPlaces = 1;
            this.numLoadStart.Location = new System.Drawing.Point(370, 28);
            this.numLoadStart.Name = "numLoadStart";
            this.numLoadStart.Size = new System.Drawing.Size(120, 22);
            this.numLoadStart.TabIndex = 16;
            // 
            // numRPMEnd
            // 
            this.numRPMEnd.Location = new System.Drawing.Point(102, 84);
            this.numRPMEnd.Maximum = new decimal(new int[] {
            7500,
            0,
            0,
            0});
            this.numRPMEnd.Name = "numRPMEnd";
            this.numRPMEnd.ReadOnly = true;
            this.numRPMEnd.Size = new System.Drawing.Size(120, 22);
            this.numRPMEnd.TabIndex = 15;
            // 
            // numRPMStep
            // 
            this.numRPMStep.Location = new System.Drawing.Point(102, 57);
            this.numRPMStep.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRPMStep.Name = "numRPMStep";
            this.numRPMStep.Size = new System.Drawing.Size(120, 22);
            this.numRPMStep.TabIndex = 14;
            // 
            // numRPMStart
            // 
            this.numRPMStart.Location = new System.Drawing.Point(102, 28);
            this.numRPMStart.Maximum = new decimal(new int[] {
            7500,
            0,
            0,
            0});
            this.numRPMStart.Name = "numRPMStart";
            this.numRPMStart.Size = new System.Drawing.Size(120, 22);
            this.numRPMStart.TabIndex = 13;
            // 
            // btnFuelMapApply
            // 
            this.btnFuelMapApply.Changed = false;
            this.btnFuelMapApply.ChangeImage = null;
            this.btnFuelMapApply.Location = new System.Drawing.Point(553, 15);
            this.btnFuelMapApply.Name = "btnFuelMapApply";
            this.btnFuelMapApply.Size = new System.Drawing.Size(105, 31);
            this.btnFuelMapApply.TabIndex = 12;
            this.btnFuelMapApply.Text = "Apply";
            this.btnFuelMapApply.UseVisualStyleBackColor = true;
            this.btnFuelMapApply.Click += new System.EventHandler(this.btnFuelMapApply_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Load End:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Load Step:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Load Start:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "RPM End:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "RPM Step:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "RPM Start:";
            // 
            // headerControl4
            // 
            this.headerControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerControl4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.headerControl4.HeaderText = "Fuel Map:";
            this.headerControl4.LineColor = System.Drawing.Color.Silver;
            this.headerControl4.Location = new System.Drawing.Point(3, 10);
            this.headerControl4.Name = "headerControl4";
            this.headerControl4.Size = new System.Drawing.Size(780, 35);
            this.headerControl4.TabIndex = 3;
            this.headerControl4.TextColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // tpComm
            // 
            this.tpComm.Controls.Add(this.btnSerialDisconnect);
            this.tpComm.Controls.Add(this.btnSerialConnect);
            this.tpComm.Controls.Add(this.gbSerialSpeed);
            this.tpComm.Controls.Add(this.gbSerialport);
            this.tpComm.Controls.Add(this.headerControl5);
            this.tpComm.Location = new System.Drawing.Point(4, 52);
            this.tpComm.Name = "tpComm";
            this.tpComm.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tpComm.Size = new System.Drawing.Size(786, 505);
            this.tpComm.TabIndex = 3;
            this.tpComm.Text = "Communication";
            this.tpComm.UseVisualStyleBackColor = true;
            // 
            // btnSerialDisconnect
            // 
            this.btnSerialDisconnect.Changed = false;
            this.btnSerialDisconnect.ChangeImage = null;
            this.btnSerialDisconnect.Enabled = false;
            this.btnSerialDisconnect.Location = new System.Drawing.Point(134, 51);
            this.btnSerialDisconnect.Name = "btnSerialDisconnect";
            this.btnSerialDisconnect.Size = new System.Drawing.Size(97, 43);
            this.btnSerialDisconnect.TabIndex = 7;
            this.btnSerialDisconnect.Text = "Disconnect";
            this.btnSerialDisconnect.UseVisualStyleBackColor = true;
            this.btnSerialDisconnect.Click += new System.EventHandler(this.btnSerialDisconnect_Click);
            // 
            // btnSerialConnect
            // 
            this.btnSerialConnect.Changed = false;
            this.btnSerialConnect.ChangeImage = null;
            this.btnSerialConnect.Enabled = false;
            this.btnSerialConnect.Location = new System.Drawing.Point(31, 51);
            this.btnSerialConnect.Name = "btnSerialConnect";
            this.btnSerialConnect.Size = new System.Drawing.Size(97, 43);
            this.btnSerialConnect.TabIndex = 6;
            this.btnSerialConnect.Text = "Connect";
            this.btnSerialConnect.UseVisualStyleBackColor = true;
            this.btnSerialConnect.Click += new System.EventHandler(this.btnSerialConnect_Click);
            // 
            // gbSerialSpeed
            // 
            this.gbSerialSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.gbSerialSpeed.BorderColor = System.Drawing.Color.Silver;
            this.gbSerialSpeed.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbSerialSpeed.Location = new System.Drawing.Point(336, 103);
            this.gbSerialSpeed.Name = "gbSerialSpeed";
            this.gbSerialSpeed.Padding = new System.Windows.Forms.Padding(10);
            this.gbSerialSpeed.Size = new System.Drawing.Size(269, 376);
            this.gbSerialSpeed.TabIndex = 5;
            this.gbSerialSpeed.TabStop = false;
            this.gbSerialSpeed.Text = "Speed:";
            // 
            // gbSerialport
            // 
            this.gbSerialport.BackColor = System.Drawing.SystemColors.Control;
            this.gbSerialport.BorderColor = System.Drawing.Color.Silver;
            this.gbSerialport.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbSerialport.Location = new System.Drawing.Point(21, 103);
            this.gbSerialport.Name = "gbSerialport";
            this.gbSerialport.Padding = new System.Windows.Forms.Padding(10);
            this.gbSerialport.Size = new System.Drawing.Size(269, 376);
            this.gbSerialport.TabIndex = 4;
            this.gbSerialport.TabStop = false;
            this.gbSerialport.Text = "Serial Ports:";
            // 
            // headerControl5
            // 
            this.headerControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerControl5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.headerControl5.HeaderText = "Communication:";
            this.headerControl5.LineColor = System.Drawing.Color.Silver;
            this.headerControl5.Location = new System.Drawing.Point(3, 10);
            this.headerControl5.Name = "headerControl5";
            this.headerControl5.Size = new System.Drawing.Size(780, 35);
            this.headerControl5.TabIndex = 3;
            this.headerControl5.TextColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // FrmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "FrmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E.I.T. Flex Fuel Application";
            this.Load += new System.EventHandler(this.FrmMainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpInfo.ResumeLayout(false);
            this.customGroupBox1.ResumeLayout(false);
            this.customGroupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tpSetting.ResumeLayout(false);
            this.tpFuelMap.ResumeLayout(false);
            this.gpFuelMapTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpFuelMapSetting.ResumeLayout(false);
            this.gpFuelMapSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLoadEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoadStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoadStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRPMEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRPMStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRPMStart)).EndInit();
            this.tpComm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.TabPage tpSetting;
        private Controls.TabButton tbSettings;
        private Controls.TabButton tbInfo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private Controls.StatusControl scRPMAcc;
        private Controls.StatusControl scRPM;
        private Controls.StatusControl scLoadAcc;
        private Controls.StatusControl scLoad;
        private Controls.StatusControl scFuelAdjust;
        private Controls.StatusControl scRPMDutyCycle;
        private Controls.CustomGroupBox customGroupBox1;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private Controls.HeaderControl headerControl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controls.HeaderControl headerControl3;
        private Controls.TabButton tbFuelMap;
        private System.Windows.Forms.TabPage tpFuelMap;
        private Controls.HeaderControl headerControl4;
        private Controls.HeaderControl headerControl1;
        private System.Windows.Forms.GroupBox gpFuelMapTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpFuelMapSetting;
        private Controls.TabButton tbCommunication;
        private System.Windows.Forms.TabPage tpComm;
        private Controls.HeaderControl headerControl5;
        private Controls.CustomGroupBox gbSerialport;
        private Controls.CustomGroupBox gbSerialSpeed;
        private Controls.CustomButton btnSerialConnect;
        private Controls.CustomButton btnSerialDisconnect;
        private Controls.SwitchControl swFeatures;
        private Controls.SwitchControl swSysMon;
        private Controls.SwitchControl swLoadAcc;
        private Controls.SwitchControl swRPMAcc;
        private Controls.SwitchControl swFuelMap;
        private Controls.SwitchControl swInjMon;
        private Controls.CustomButton btnSendCmd;
        private Controls.CustomButton btnRefresh;
        private Controls.CustomButton btnClearMessage;
        private System.Windows.Forms.TextBox txtCommandText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Controls.CustomButton btnFuelMapApply;
        private System.Windows.Forms.NumericUpDown numLoadEnd;
        private System.Windows.Forms.NumericUpDown numLoadStep;
        private System.Windows.Forms.NumericUpDown numLoadStart;
        private System.Windows.Forms.NumericUpDown numRPMEnd;
        private System.Windows.Forms.NumericUpDown numRPMStep;
        private System.Windows.Forms.NumericUpDown numRPMStart;
        private Controls.CustomButton btnFuelMapCal;
        private System.Windows.Forms.Button btnFuelMapRead;




    }
}