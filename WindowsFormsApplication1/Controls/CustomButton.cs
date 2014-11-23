using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace EITFlex.Controls
{
    public class CustomButton : Button
    {
        bool isChanged = false;
        Image changeImage;
        Image orgImage;

        [Browsable(true)]
        public Image ChangeImage
        {
            get { return changeImage; }
            set
            {
                changeImage = value;
            }
        }

        public bool Changed
        {
            get { return isChanged; }
            set {
                isChanged = value;
                if(value)
                {
                    if (orgImage == null)
                        orgImage = BackgroundImage;

                    BackgroundImage = changeImage;
                }
                else
                {
                    if (orgImage != null)
                        BackgroundImage = orgImage;
                }
            }
        }

        public CustomButton()
        {
        }
    }
}
