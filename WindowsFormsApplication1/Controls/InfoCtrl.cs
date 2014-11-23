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
    public partial class InfoCtrl : UserControl
    {
        int mValue = 0;

        public string Unit
        {
            get { return lblUnit.Text; }
            set { lblUnit.Text = value; }
        }

        public string Title
        {
            get { return gbName.Text; }
            set { gbName.Text = value; }
        }

        public int Value
        {
            get { return mValue; }
            set
            {
                mValue = value;
                txtValue.Text = string.Format("{0}", value);
            }
        }

        public InfoCtrl()
        {
            InitializeComponent();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
