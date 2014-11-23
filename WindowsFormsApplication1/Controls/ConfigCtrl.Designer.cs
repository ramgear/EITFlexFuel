namespace EITFlex.Controls
{
    partial class ConfigCtrl
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbName = new EITFlex.Controls.CustomGroupBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnApply = new EITFlex.Controls.CustomButton();
            this.txtValue = new EITFlex.Controls.CustomTextBox();
            this.gbName.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // gbName
            // 
            this.gbName.BorderColor = System.Drawing.Color.Silver;
            this.gbName.Controls.Add(this.lblUnit);
            this.gbName.Controls.Add(this.btnApply);
            this.gbName.Controls.Add(this.txtValue);
            this.gbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbName.Location = new System.Drawing.Point(0, 0);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(186, 55);
            this.gbName.TabIndex = 0;
            this.gbName.TabStop = false;
            this.gbName.Text = "Name:";
            this.gbName.Enter += new System.EventHandler(this.gbName_Enter);
            // 
            // lblUnit
            // 
            this.lblUnit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUnit.Location = new System.Drawing.Point(110, 16);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(28, 32);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "%";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUnit.Click += new System.EventHandler(this.lblUnit_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnApply.BackgroundImage = global::EITFlex.Properties.Resources.check24;
            this.btnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApply.Changed = false;
            this.btnApply.ChangeImage = global::EITFlex.Properties.Resources.check24_led;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnApply.Location = new System.Drawing.Point(145, 16);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(32, 32);
            this.btnApply.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnApply, "Apply change.");
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.BorderColor = System.Drawing.Color.Silver;
            this.txtValue.ForeColor = System.Drawing.Color.Blue;
            this.txtValue.Location = new System.Drawing.Point(8, 16);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(95, 32);
            this.txtValue.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtValue, "Change value.");
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // ConfigCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbName);
            this.Name = "ConfigCtrl";
            this.Size = new System.Drawing.Size(186, 55);
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton btnApply;
        private System.Windows.Forms.Label lblUnit;
        private CustomGroupBox gbName;
        private CustomTextBox txtValue;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}
