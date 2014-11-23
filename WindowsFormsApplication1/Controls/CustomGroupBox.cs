﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace EITFlex.Controls
{
    public class CustomGroupBox : GroupBox
    {
        private Color borderColor;

        public Color BorderColor
        {
            get { return this.borderColor; }
            set { 
                this.borderColor = value;
                this.Invalidate();
            }
        }

        public CustomGroupBox()
        {
            this.borderColor = Color.Silver;
            this.ForeColor = SystemColors.ControlDarkDark;
            this.BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Size tSize = TextRenderer.MeasureText(this.Text, this.Font);

            Rectangle borderRect = e.ClipRectangle;
            borderRect.Y += tSize.Height / 2;
            borderRect.Height -= tSize.Height / 2;
            ControlPaint.DrawBorder(e.Graphics, borderRect, this.borderColor, ButtonBorderStyle.Solid);

            Rectangle textRect = e.ClipRectangle;
            textRect.X += 6;
            textRect.Width = tSize.Width;
            textRect.Height = tSize.Height;
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRect);
        }
    }
}
