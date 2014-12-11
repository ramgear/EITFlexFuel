using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace EITFlex.Controls
{
    public class TabButton : Button
    {
        [Browsable(true)]
        public Color NormalColor { get; set; }

        [Browsable(true)]
        public Color SelectedColor { get; set; }

        bool bSelected = false;
        public bool Selected {
            get { return bSelected; }
            set
            {
                bSelected = value;
                if (value)
                    this.BackColor = this.SelectedColor;
                else
                    this.BackColor = this.NormalColor;
            }
        }

        public TabButton()
        {
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoSize = false;
            this.BackColor = Color.Transparent;

            this.NormalColor = SystemColors.ControlDarkDark;
            this.SelectedColor = Color.LimeGreen;
            this.Height = 50;
            this.Dock = DockStyle.Top;
            this.ForeColor = Color.White;
            this.Font = new Font("Calibri", 14, FontStyle.Regular);
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.ImageAlign = ContentAlignment.MiddleLeft;
            this.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            this.Selected = true;
        }
    }
}
