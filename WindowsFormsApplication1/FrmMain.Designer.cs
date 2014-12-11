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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpSetting = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cfgLoadAdjStep = new EITFlex.Controls.ConfigCtrl();
            this.cfgLoadStart = new EITFlex.Controls.ConfigCtrl();
            this.cfgLoadEnd = new EITFlex.Controls.ConfigCtrl();
            this.cfgLoadCount = new EITFlex.Controls.ConfigCtrl();
            this.cfgRPMAdjStep = new EITFlex.Controls.ConfigCtrl();
            this.cfgRPMEnd = new EITFlex.Controls.ConfigCtrl();
            this.cfgRPMStart = new EITFlex.Controls.ConfigCtrl();
            this.cfgRPMCount = new EITFlex.Controls.ConfigCtrl();
            this.tpInjectors = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tpSysInfo = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusControl6 = new EITFlex.Controls.StatusControl();
            this.statusControl5 = new EITFlex.Controls.StatusControl();
            this.statusControl4 = new EITFlex.Controls.StatusControl();
            this.statusControl3 = new EITFlex.Controls.StatusControl();
            this.statusControl2 = new EITFlex.Controls.StatusControl();
            this.statusControl1 = new EITFlex.Controls.StatusControl();
            this.headerControl1 = new EITFlex.Controls.HeaderControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.customGroupBox1 = new EITFlex.Controls.CustomGroupBox();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.tcMain.SuspendLayout();
            this.tpSetting.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tpSysInfo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customGroupBox1.SuspendLayout();
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
            this.tcMain.Size = new System.Drawing.Size(1008, 729);
            this.tcMain.TabIndex = 0;
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
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
            // tpSysInfo
            // 
            this.tpSysInfo.BackColor = System.Drawing.Color.White;
            this.tpSysInfo.Controls.Add(this.panel3);
            this.tpSysInfo.Controls.Add(this.panel2);
            this.tpSysInfo.Controls.Add(this.panel1);
            this.tpSysInfo.Location = new System.Drawing.Point(4, 25);
            this.tpSysInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tpSysInfo.Name = "tpSysInfo";
            this.tpSysInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tpSysInfo.Size = new System.Drawing.Size(1000, 700);
            this.tpSysInfo.TabIndex = 0;
            this.tpSysInfo.Text = "System Settings:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customGroupBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(565, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 628);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statusControl6);
            this.panel2.Controls.Add(this.statusControl5);
            this.panel2.Controls.Add(this.statusControl4);
            this.panel2.Controls.Add(this.statusControl3);
            this.panel2.Controls.Add(this.statusControl2);
            this.panel2.Controls.Add(this.statusControl1);
            this.panel2.Controls.Add(this.headerControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(4, 68);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(561, 628);
            this.panel2.TabIndex = 4;
            // 
            // statusControl6
            // 
            this.statusControl6.BackColor = System.Drawing.Color.Transparent;
            this.statusControl6.DetailText = "RPM change per second.";
            this.statusControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusControl6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusControl6.HeaderText = "RPM Acceleration: ";
            this.statusControl6.Location = new System.Drawing.Point(0, 319);
            this.statusControl6.Maximum = 100;
            this.statusControl6.Minimum = 0;
            this.statusControl6.Name = "statusControl6";
            this.statusControl6.Padding = new System.Windows.Forms.Padding(5);
            this.statusControl6.Size = new System.Drawing.Size(561, 55);
            this.statusControl6.TabIndex = 6;
            this.statusControl6.Unit = " RPM/s";
            this.statusControl6.Value = 80;
            // 
            // statusControl5
            // 
            this.statusControl5.BackColor = System.Drawing.Color.Transparent;
            this.statusControl5.DetailText = "Current rotation per minute.";
            this.statusControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusControl5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusControl5.HeaderText = "RPM: ";
            this.statusControl5.Location = new System.Drawing.Point(0, 264);
            this.statusControl5.Maximum = 4000;
            this.statusControl5.Minimum = 800;
            this.statusControl5.Name = "statusControl5";
            this.statusControl5.Padding = new System.Windows.Forms.Padding(5);
            this.statusControl5.Size = new System.Drawing.Size(561, 55);
            this.statusControl5.TabIndex = 5;
            this.statusControl5.Unit = "";
            this.statusControl5.Value = 2000;
            // 
            // statusControl4
            // 
            this.statusControl4.BackColor = System.Drawing.Color.Transparent;
            this.statusControl4.DetailText = "Load percent change per second.";
            this.statusControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusControl4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusControl4.HeaderText = "Load Acceleration: ";
            this.statusControl4.Location = new System.Drawing.Point(0, 209);
            this.statusControl4.Maximum = 100;
            this.statusControl4.Minimum = 0;
            this.statusControl4.Name = "statusControl4";
            this.statusControl4.Padding = new System.Windows.Forms.Padding(5);
            this.statusControl4.Size = new System.Drawing.Size(561, 55);
            this.statusControl4.TabIndex = 4;
            this.statusControl4.Unit = " %/s";
            this.statusControl4.Value = 80;
            // 
            // statusControl3
            // 
            this.statusControl3.BackColor = System.Drawing.Color.Transparent;
            this.statusControl3.DetailText = "Current load value.";
            this.statusControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusControl3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusControl3.HeaderText = "Load: ";
            this.statusControl3.Location = new System.Drawing.Point(0, 154);
            this.statusControl3.Maximum = 100;
            this.statusControl3.Minimum = 0;
            this.statusControl3.Name = "statusControl3";
            this.statusControl3.Padding = new System.Windows.Forms.Padding(5);
            this.statusControl3.Size = new System.Drawing.Size(561, 55);
            this.statusControl3.TabIndex = 3;
            this.statusControl3.Value = 80;
            // 
            // statusControl2
            // 
            this.statusControl2.BackColor = System.Drawing.Color.Transparent;
            this.statusControl2.DetailText = "Current fuel adjestment include manual, acceleration & mapping.";
            this.statusControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusControl2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusControl2.HeaderText = "Fuel Adjustment: ";
            this.statusControl2.Location = new System.Drawing.Point(0, 99);
            this.statusControl2.Maximum = 35;
            this.statusControl2.Minimum = 0;
            this.statusControl2.Name = "statusControl2";
            this.statusControl2.Padding = new System.Windows.Forms.Padding(5);
            this.statusControl2.Size = new System.Drawing.Size(561, 55);
            this.statusControl2.TabIndex = 2;
            this.statusControl2.Value = 25;
            // 
            // statusControl1
            // 
            this.statusControl1.BackColor = System.Drawing.Color.Transparent;
            this.statusControl1.DetailText = "Maximum injector duty cycle limit.";
            this.statusControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusControl1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusControl1.HeaderText = "Duty Cycle: ";
            this.statusControl1.Location = new System.Drawing.Point(0, 44);
            this.statusControl1.Maximum = 100;
            this.statusControl1.Minimum = 0;
            this.statusControl1.Name = "statusControl1";
            this.statusControl1.Padding = new System.Windows.Forms.Padding(5);
            this.statusControl1.Size = new System.Drawing.Size(561, 55);
            this.statusControl1.TabIndex = 0;
            this.statusControl1.Value = 80;
            // 
            // headerControl1
            // 
            this.headerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerControl1.HeaderText = "Device Status";
            this.headerControl1.LineColor = System.Drawing.Color.Aquamarine;
            this.headerControl1.Location = new System.Drawing.Point(0, 10);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(561, 34);
            this.headerControl1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 64);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EITFlex.Properties.Resources.download;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 64);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(431, 38);
            this.panel4.TabIndex = 0;
            // 
            // customGroupBox1
            // 
            this.customGroupBox1.BackColor = System.Drawing.Color.White;
            this.customGroupBox1.BorderColor = System.Drawing.Color.Silver;
            this.customGroupBox1.Controls.Add(this.tbxMessage);
            this.customGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.customGroupBox1.Location = new System.Drawing.Point(0, 38);
            this.customGroupBox1.Name = "customGroupBox1";
            this.customGroupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.customGroupBox1.Size = new System.Drawing.Size(431, 590);
            this.customGroupBox1.TabIndex = 1;
            this.customGroupBox1.TabStop = false;
            this.customGroupBox1.Text = "System Message:";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMessage.Location = new System.Drawing.Point(5, 20);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.ReadOnly = true;
            this.tbxMessage.Size = new System.Drawing.Size(421, 565);
            this.tbxMessage.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "EIT Flex Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tcMain.ResumeLayout(false);
            this.tpSetting.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tpSysInfo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customGroupBox1.ResumeLayout(false);
            this.customGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpSetting;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Controls.ConfigCtrl cfgLoadAdjStep;
        private Controls.ConfigCtrl cfgLoadStart;
        private Controls.ConfigCtrl cfgLoadEnd;
        private Controls.ConfigCtrl cfgLoadCount;
        private Controls.ConfigCtrl cfgRPMAdjStep;
        private Controls.ConfigCtrl cfgRPMEnd;
        private Controls.ConfigCtrl cfgRPMStart;
        private Controls.ConfigCtrl cfgRPMCount;
        private System.Windows.Forms.TabPage tpInjectors;
        private System.Windows.Forms.TabPage tpSysInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Controls.StatusControl statusControl6;
        private Controls.StatusControl statusControl5;
        private Controls.StatusControl statusControl4;
        private Controls.StatusControl statusControl3;
        private Controls.StatusControl statusControl2;
        private Controls.StatusControl statusControl1;
        private Controls.HeaderControl headerControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.CustomGroupBox customGroupBox1;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Panel panel4;
    }
}

