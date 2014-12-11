using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EITFlex.Controls
{
    public partial class HeaderControl : UserControl
    {

        [Category("Appearance"), Description("Line color..")]
        [Browsable(true)]
        public Color LineColor { get; set; }

        [Category("Appearance"), Description("Header text color..")]
        [Browsable(true)]
        public Color TextColor 
        {
            get { return label1.ForeColor; }
            set { label1.ForeColor = value; }  
        }

        [Category("Appearance"), Description("Header text at top.")]
        [Browsable(true)]
        [DefaultValue("Header text: ")]
        public string HeaderText
        {
            get { return label1.Text; }
            set
            {
                label1.Text = value;
            }
        }

        public HeaderControl()
        {
            InitializeComponent();

            this.LineColor = Color.Black;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Pen pen = new Pen(this.LineColor, 1);

            e.Graphics.DrawLine(pen, label1.Left, label1.Bottom + 2, label1.Right, label1.Bottom + 2);
        }
    }
}
