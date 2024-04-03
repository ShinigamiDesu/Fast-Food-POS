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
    public partial class FoodItems : UserControl
    {
        private string _Name;
        private string _ID;
        private string _Description;
        private string _Price;
        private Image _Image;
        cusForm cus;


        public FoodItems(cusForm cus)
        {
            InitializeComponent();
            this.cus = cus;
        }

        public string ID { get { return _ID; } set { _ID = value; } }
        public string Name { get { return _Name; } set { _Name = value; lbl_name.Text = value; } }
        public string Desc { get { return _Description; } set { _Description = value; } }
        public string Price { get { return _Price; } set { _Price = value; lbl_price.Text = value; } }
        public Image Pic { get { return _Image; } set { _Image = value; pic_item.Image = value; } }

        public void setStock() 
        {
            lbl_stock.Visible = true;
            lbl_stock.Location = new Point(128, 190);
            btn_add.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cus.displayItemDetails(_Name, _Price, _Image, _Description, ID);
        }
    }
}
