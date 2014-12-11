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
    public partial class SwitchControl : UserControl
    {
        public event EventHandler OnSet;
        public event EventHandler OnStatChanged;

        public bool Stat
        {
            get { return (tgbEnable.ToggleState == ToggleButton.ToggleButtonState.ON); }
            set
            {
                tgbEnable.ToggleState = value ? ToggleButton.ToggleButtonState.ON : ToggleButton.ToggleButtonState.OFF;
            }
        }

        public string HeaderText
        {
            get { return lblHeader.Text; }
            set { lblHeader.Text = value; } 
        }
        public string Detial
        {
            get { return lblDetial.Text; }
            set { lblDetial.Text = value; } 
        }

        public string Label1
        {
            get { return lblLabel1.Text; }
            set { lblLabel1.Text = value; }
        }

        public string Label2
        {
            get { return lblLabel2.Text; }
            set { lblLabel2.Text = value; }
        }

        public decimal Minimum1
        {
            get { return numValue1.Minimum; }
            set { numValue1.Minimum = value; }
        }

        public decimal Maximum1
        {
            get { return numValue1.Maximum; }
            set { numValue1.Maximum = value; }
        }
        
        public decimal Value1
        {
            get { return numValue1.Value; }
            set { numValue1.Value = value; }
        }

        public decimal Minimum2
        {
            get { return numValue2.Minimum; }
            set { numValue2.Minimum = value; }
        }

        public decimal Maximum2
        {
            get { return numValue2.Maximum; }
            set { numValue2.Maximum = value; }
        }

        public decimal Value2
        {
            get { return numValue2.Value; }
            set { numValue2.Value = value; }
        }

        public bool Value1Visible
        {
            get { return numValue1.Visible; }
            set {
                numValue1.Visible = value;
                lblLabel1.Visible = value; 
            }
        }
        /*
        public bool ReadOnly
        {
            get { return !btnSet.Visible; }
            set
            {
                btnSet.Visible = !value;
                numValue1.ReadOnly = value;
                numValue2.ReadOnly = value;
            }
        }*/

        public SwitchControl()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            tgbEnable.ButtonStateChanged += tgbEnable_ButtonStateChanged;
            btnSet.Click += btnSet_Click;
        }

        void btnSet_Click(object sender, EventArgs e)
        {
            if (this.OnSet != null)
                this.OnSet(this, e);
        }

        void tgbEnable_ButtonStateChanged(object sender, ToggleButton.ToggleButtonStateEventArgs e)
        {
            ToggleButton btn = sender as ToggleButton;

            if(btn.ToggleState != ToggleButton.ToggleButtonState.ON)
            {
                numValue2.ReadOnly = numValue1.ReadOnly = false;
                btnSet.Enabled = true;
            }
            else
            {
                numValue2.ReadOnly = numValue1.ReadOnly = true;
                btnSet.Enabled = false;
            }

            if (this.OnStatChanged != null)
                this.OnStatChanged(this, e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = panel1.CreateGraphics();
            Point pt1 = new Point(5, panel1.Bottom - 1);
            Point pt2 = new Point(panel1.Right - 1, pt1.Y);

            g.DrawLine(Pens.Silver, pt1, pt2);
        }
    }
}
