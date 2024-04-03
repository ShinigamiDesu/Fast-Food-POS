using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodPOS
{
    public partial class category : UserControl
    {

        private string _Name;
        private string _ID;
        private Image _Image;
        cusForm cus;

        public category(cusForm cus)
        {
            InitializeComponent();
            this.cus = cus;
        }

        public string ID { get { return _ID; } set { _ID = value; } }
        public string Name { get { return _Name; } set { _Name = value; lbl_name.Text = value; } }
        public Image Pic { get { return _Image; } set { _Image = value; pic_category.Image = value; } }


        private void category_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.RosyBrown;
        }

        private void category_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void category_MouseClick(object sender, MouseEventArgs e)
        {
            cus.displayCategroy(_ID, _Name);
        }
    }
}
