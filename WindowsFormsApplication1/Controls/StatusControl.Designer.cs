namespace EITFlex.Controls
{
    partial class StatusControl
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.progressBarEx1 = new EITFlex.Controls.ProgressBarEx();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeader.Location = new System.Drawing.Point(5, 5);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(440, 18);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Header Text: ";
            // 
            // lblMinimum
            // 
            this.lblMinimum.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMinimum.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMinimum.Location = new System.Drawing.Point(5, 39);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(43, 16);
            this.lblMinimum.TabIndex = 1;
            this.lblMinimum.Text = "0";
            this.lblMinimum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMaximum
            // 
            this.lblMaximum.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMaximum.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMaximum.Location = new System.Drawing.Point(395, 39);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(50, 16);
            this.lblMaximum.TabIndex = 2;
            this.lblMaximum.Text = "100";
            // 
            // lblDetail
            // 
            this.lblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDetail.Location = new System.Drawing.Point(5, 23);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblDetail.Size = new System.Drawing.Size(440, 16);
            this.lblDetail.TabIndex = 3;
            this.lblDetail.Text = "Detail";
            // 
            // progressBarEx1
            // 
            this.progressBarEx1.BackColor = System.Drawing.Color.Silver;
            this.progressBarEx1.BorderColor = System.Drawing.Color.Silver;
            this.progressBarEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBarEx1.GradiantPosition = EITFlex.Controls.ProgressBarEx.GradiantArea.None;
            this.progressBarEx1.Image = null;
            this.progressBarEx1.Location = new System.Drawing.Point(48, 39);
            this.progressBarEx1.Name = "progressBarEx1";
            this.progressBarEx1.ProgressColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBarEx1.Size = new System.Drawing.Size(347, 10);
            this.progressBarEx1.Text = "progressBarEx1";
            this.progressBarEx1.Value = 80;
            // 
            // StatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.progressBarEx1);
            this.Controls.Add(this.lblMaximum);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblHeader);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StatusControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(450, 60);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblMaximum;
        private ProgressBarEx progressBarEx1;
        private System.Windows.Forms.Label lblDetail;
    }
}
