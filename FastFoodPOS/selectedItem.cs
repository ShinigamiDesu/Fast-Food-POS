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
    public partial class selectedItem : Form
    {
        private string _Name;
        private string _ID;
        private string _Description;
        private string _Price;
        private Image _Image;
        cusForm cus;

        public selectedItem(cusForm cus)
        {
            InitializeComponent();
            this.cus = cus;
        }
        public string ID { get { return _ID; } set { _ID = value; } }
        public string Name { get { return _Name; } set { _Name = value; lbl_name.Text = value; } }
        public string Desc { get { return _Description; } set { _Description = value; lbl_description.Text = value; } }
        public string Price { get { return _Price; } set { _Price = value; lbl_price.Text = value; } }
        public Image Pic { get { return _Image; } set { _Image = value; pic_item.Image = value; } }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cus.addToCart(Name, Price, Desc, ID, Pic, txt_quantity.Text);
            cus.setCartVisible(true);
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectedItem_Load(object sender, EventArgs e)
        {
            if(txt_quantity.Text == "1") 
            { 
                btn_descrease.Enabled = false;
            }
        }

        private void btn_increase_Click(object sender, EventArgs e)
        {
            btn_descrease.Enabled=true;
            int amount = int.Parse(txt_quantity.Text);
            amount = amount + 1;
            txt_quantity.Text = amount.ToString();
        }

        private void btn_descrease_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(txt_quantity.Text);
            if (amount == 2)
            {
                btn_descrease.Enabled = false;
            }
            else
            {
                btn_descrease.Enabled = true;
            }
            amount = amount - 1;
            txt_quantity.Text = amount.ToString();
        }


    }
}
