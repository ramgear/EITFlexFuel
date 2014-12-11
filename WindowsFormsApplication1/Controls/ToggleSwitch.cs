using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EITFlex.Controls
{
    public partial class ToggleSwitch : UserControl
    {
        public Color OnColor { get; set; }
        public Color OffColor { get; set; }
        public bool Status { get; set; }

        public ToggleSwitch()
        {
            InitializeComponent();

            this.OnColor = Color.LimeGreen;
            this.OffColor = Color.Silver;
        }

        private void ToggleSwitch_Load(object sender, EventArgs e)
        {
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicExt g = new GraphicExt(e.Graphics);

            Color bgColor;
            string strText;
            if (this.Status)
            {
                bgColor = this.OnColor;
                strText = "On";
            }
            else
            {
                bgColor = this.OffColor;
                strText = "Off";
            }

            // draw background
            g.FillRoundRectangle(new SolidBrush(bgColor), 0, 0, this.Width, this.Height, 5);

            SizeF size = g.Graphics.MeasureString(strText, this.Font);
        }


    }
}
