namespace EITFlex.Controls
{
    partial class InfoCtrl
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
            this.gbName = new EITFlex.Controls.CustomGroupBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtValue = new CustomTextBox();
            this.gbName.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbName
            // 
            this.gbName.BorderColor = System.Drawing.Color.Silver;
            this.gbName.Controls.Add(this.lblUnit);
            this.gbName.Controls.Add(this.txtValue);
            this.gbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbName.Location = new System.Drawing.Point(0, 0);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(186, 55);
            this.gbName.TabIndex = 1;
            this.gbName.TabStop = false;
            this.gbName.Text = "Name:";
            // 
            // lblUnit
            // 
            this.lblUnit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUnit.Location = new System.Drawing.Point(110, 16);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(70, 32);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "%";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.Location = new System.Drawing.Point(6, 16);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.Size = new System.Drawing.Size(100, 32);
            this.txtValue.TabIndex = 0;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // InfoCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbName);
            this.Name = "InfoCtrl";
            this.Size = new System.Drawing.Size(186, 55);
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomGroupBox gbName;
        private System.Windows.Forms.Label lblUnit;
        private CustomTextBox txtValue;

    }
}
