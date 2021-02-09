using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomButton
{
    public partial class CustomButton: PictureBox
    {
        private Image normalImage;
        private Image hoverImage;

        public delegate void MyDelegate(object sender, MouseEventArgs e);
        public event MyDelegate MyEvent;
        
        public CustomButton()
        {
            InitializeComponent();
        }

        public Image ImageNormal
        {
            get { return normalImage; }
            set { normalImage = value; }
        }

        public Image ImageHover
        {
            get { return hoverImage; }
            set { hoverImage = value; }
        }

        private void CustomButton_MouseHover(object sender, EventArgs e)
        {
            Image = hoverImage;
        }

        private void CustomButton_MouseLeave(object sender, EventArgs e)
        {
            Image = normalImage;
        }

        private void CustomButton_MouseClick(object sender, MouseEventArgs e)
        {
            if(MyEvent!=null)
                MyEvent.Invoke(sender, e);
        }
    }
}
