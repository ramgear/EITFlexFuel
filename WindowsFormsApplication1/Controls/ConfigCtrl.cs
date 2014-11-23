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
    public partial class ConfigCtrl : UserControl
    {
        int mValue = 0;
        int mMin = 0;
        int mMax = 100;

        public event EventHandler OnValueChanged;

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

        public int Min
        {
            get { return mMin; }
            set
            {
                mMin = value;
                if (mValue < mMin)
                    mValue = mMin;
            }
        }

        public int Max
        {
            get { return mMax; }
            set
            {
                mMax = value;
                if (mValue > mMax)
                    mValue = mMax;
            }
        }

        public ConfigCtrl()
        {
            InitializeComponent();

            txtValue.KeyPress += txtValue_KeyPress;
            txtValue.Leave += txtValue_Leave;
            txtValue.Enter += txtValue_Enter;
        }

        void txtValue_Enter(object sender, EventArgs e)
        {
            txtValue.SelectAll();
        }

        private void ShowErrorDialog(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error Dialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void txtValue_Leave(object sender, EventArgs e)
        {
        }

        void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    btnApply_Click(sender, e);
                    txtValue.SelectAll();
                }
                else if(e.KeyChar ==(char)Keys.Escape)
                {
                    txtValue.Text = mValue.ToString();
                    btnApply.Changed = false;
                }
                else
                {
                    int tmp = mValue;
                    int.TryParse(txtValue.Text + e.KeyChar, out tmp);
                    btnApply.Changed = (tmp != mValue);
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                int tmp = mValue;
                int.TryParse(txtValue.Text, out tmp);
                if (tmp >= mMin && tmp <= mMax)
                {
                    this.Value = tmp;
                    if (OnValueChanged != null)
                        OnValueChanged(sender, e);

                    btnApply.Changed = false;
                }
                else
                {
                    if(MessageBox.Show(string.Format("Value {0} is out of {1} to {2}!\r\nDo you want to change value?", tmp, mMin, mMax), "Warning Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        txtValue.SelectAll();
                        txtValue.Focus();
                    }
                    else
                    {
                        txtValue.Text = mValue.ToString();
                        btnApply.Changed = false;
                    }
                    
                }
            }
            catch(Exception ex)
            {
                ShowErrorDialog(ex);
            }
        }

        private void gbName_Enter(object sender, EventArgs e)
        {

        }

        private void lblUnit_Click(object sender, EventArgs e)
        {

        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
