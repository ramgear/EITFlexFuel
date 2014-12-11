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
    public partial class StatusControl : UserControl
    {
        string mUnit = "%";
        string mHeaderText = "Header text:";

        [Category("Behavior"), Description("The minimum value.")]
        [Browsable(true)]
        public int Minimum 
        { 
            get
            {
                return progressBarEx1.Minimum;
            }
            set
            {
                progressBarEx1.Minimum = value;
                this.Refresh();
            }
        }

        [Category("Behavior"), Description("The maximum value.")]
        [Browsable(true)]
        public int Maximum
        {
            get
            {
                return progressBarEx1.Maximum;
            }
            set
            {
                progressBarEx1.Maximum = value;
                this.Refresh();
            }
        }

        [Category("Behavior"), Description("The current value of the ProgressBar.")]
        [Browsable(true)]
        public int Value
        {
            get { return progressBarEx1.Value; }
            set
            {
                progressBarEx1.Value = value;
                this.Refresh();
            }
        }

        [Category("Appearance"), Description("Header text at top.")]
        [Browsable(true)]
        [DefaultValue("Header text: ")]
        public string HeaderText
        {
            get { return mHeaderText; }
            set
            {
                mHeaderText = value;
                this.Refresh();
            }
        }

        [Category("Appearance"), Description("Detail text at top.")]
        [Browsable(true)]
        public string DetailText
        {
            get { return lblDetail.Text; }
            set { lblDetail.Text = value; }
        }

        [Category("Appearance"), Description("Value unit.")]
        [Browsable(true)]
        [DefaultValue("%")]
        public string Unit
        {
            get { return mUnit; }
            set { 
                mUnit = value;
                this.Refresh();
            }
        }

        public override void Refresh()
        {
            base.Refresh();

            lblHeader.Text = this.HeaderText + this.Value + this.Unit;
            lblMinimum.Text = this.Minimum.ToString() + this.Unit;
            lblMaximum.Text = this.Maximum.ToString() + this.Unit;
        }

        public StatusControl()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
    }
}
