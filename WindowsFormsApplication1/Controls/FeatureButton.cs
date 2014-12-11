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
    public class FeatureButton : Button
    {
        Color mOrgColor;
        
        bool mEnabled = false;
        public bool Enable 
        {
            get { return mEnabled; }
            set { 
                mEnabled = value;

                if (value)
                    this.BackColor = this.EnableColor;
                else
                    this.BackColor = mOrgColor;
            }
        }

        Color mEnColor = Color.Lime;

        [Browsable(true)]
        public Color EnableColor {
            get { return mEnColor; }
            set { mEnColor = value; } 
        }

        public FeatureButton()
        {
            mOrgColor = this.BackColor;
            this.Width = 80;
            this.Height = 50;
        }
    }
}
