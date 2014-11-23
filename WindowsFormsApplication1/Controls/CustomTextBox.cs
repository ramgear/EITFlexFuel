using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace EITFlex.Controls
{
    public class CustomTextBox : TextBox
    {
        private Color borderColor;

        public Color BorderColor
        {
            get { return this.borderColor; }
            set
            {
                this.borderColor = value;
                this.Invalidate();
            }
        }

        public CustomTextBox()
        {
            this.borderColor = Color.Silver;
            this.ForeColor = Color.Silver;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen penBorder = new Pen(borderColor, 1);
            Rectangle rectBorder = new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            e.Graphics.DrawRectangle(penBorder, rectBorder);
        }
    }
}
