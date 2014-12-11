namespace EITFlex.Controls
{
    partial class SwitchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblDetial = new System.Windows.Forms.Label();
            this.numValue2 = new System.Windows.Forms.NumericUpDown();
            this.btnSet = new System.Windows.Forms.Button();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.numValue1 = new System.Windows.Forms.NumericUpDown();
            this.lblLabel1 = new System.Windows.Forms.Label();
            this.lblLabel2 = new System.Windows.Forms.Label();
            this.tgbEnable = new EITFlex.Controls.ToggleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValue2)).BeginInit();
            this.pnlSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValue1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tgbEnable);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(692, 32);
            this.panel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeader.Location = new System.Drawing.Point(3, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(606, 26);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Name";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDetial
            // 
            this.lblDetial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDetial.Location = new System.Drawing.Point(0, 32);
            this.lblDetial.Name = "lblDetial";
            this.lblDetial.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblDetial.Size = new System.Drawing.Size(692, 23);
            this.lblDetial.TabIndex = 1;
            this.lblDetial.Text = "Detial";
            this.lblDetial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numValue2
            // 
            this.numValue2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.numValue2.Location = new System.Drawing.Point(482, 4);
            this.numValue2.Name = "numValue2";
            this.numValue2.ReadOnly = true;
            this.numValue2.Size = new System.Drawing.Size(120, 22);
            this.numValue2.TabIndex = 2;
            // 
            // btnSet
            // 
            this.btnSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSet.Enabled = false;
            this.btnSet.Location = new System.Drawing.Point(608, 3);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // pnlSetting
            // 
            this.pnlSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSetting.Controls.Add(this.lblLabel2);
            this.pnlSetting.Controls.Add(this.lblLabel1);
            this.pnlSetting.Controls.Add(this.numValue1);
            this.pnlSetting.Controls.Add(this.numValue2);
            this.pnlSetting.Controls.Add(this.btnSet);
            this.pnlSetting.Location = new System.Drawing.Point(3, 58);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(686, 35);
            this.pnlSetting.TabIndex = 4;
            // 
            // numValue1
            // 
            this.numValue1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.numValue1.Location = new System.Drawing.Point(165, 4);
            this.numValue1.Name = "numValue1";
            this.numValue1.ReadOnly = true;
            this.numValue1.Size = new System.Drawing.Size(120, 22);
            this.numValue1.TabIndex = 4;
            // 
            // lblLabel1
            // 
            this.lblLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLabel1.Location = new System.Drawing.Point(3, 4);
            this.lblLabel1.Name = "lblLabel1";
            this.lblLabel1.Size = new System.Drawing.Size(156, 22);
            this.lblLabel1.TabIndex = 5;
            this.lblLabel1.Text = "label1";
            this.lblLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLabel2
            // 
            this.lblLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLabel2.Location = new System.Drawing.Point(320, 4);
            this.lblLabel2.Name = "lblLabel2";
            this.lblLabel2.Size = new System.Drawing.Size(156, 22);
            this.lblLabel2.TabIndex = 6;
            this.lblLabel2.Text = "label2";
            this.lblLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tgbEnable
            // 
            this.tgbEnable.ActiveColor = System.Drawing.Color.LimeGreen;
            this.tgbEnable.ActiveText = "ON";
            this.tgbEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tgbEnable.BackColor = System.Drawing.Color.White;
            this.tgbEnable.InActiveColor = System.Drawing.Color.Silver;
            this.tgbEnable.InActiveText = "OFF";
            this.tgbEnable.Location = new System.Drawing.Point(612, 5);
            this.tgbEnable.MaximumSize = new System.Drawing.Size(119, 32);
            this.tgbEnable.MinimumSize = new System.Drawing.Size(65, 23);
            this.tgbEnable.Name = "tgbEnable";
            this.tgbEnable.Size = new System.Drawing.Size(75, 23);
            this.tgbEnable.SliderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tgbEnable.SlidingAngle = 5;
            this.tgbEnable.TabIndex = 1;
            this.tgbEnable.Text = "toggleButton1";
            this.tgbEnable.TextColor = System.Drawing.Color.White;
            this.tgbEnable.ToggleState = EITFlex.Controls.ToggleButton.ToggleButtonState.OFF;
            this.tgbEnable.ToggleStyle = EITFlex.Controls.ToggleButton.ToggleButtonStyle.Windows;
            // 
            // SwitchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDetial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSetting);
            this.Name = "SwitchControl";
            this.Size = new System.Drawing.Size(692, 96);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numValue2)).EndInit();
            this.pnlSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numValue1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblDetial;
        private ToggleButton tgbEnable;
        private System.Windows.Forms.NumericUpDown numValue2;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.Label lblLabel2;
        private System.Windows.Forms.Label lblLabel1;
        private System.Windows.Forms.NumericUpDown numValue1;

    }
}
