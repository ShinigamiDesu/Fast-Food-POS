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
    public partial class ItemsCart : UserControl
    {
       
        private string _Name;
        private string _ID;
        private string _Description;
        private string _Total;
        private string _Quantity;
        private Image _Image;
        Cart cart;


        public ItemsCart(Cart cart)
        {
            InitializeComponent();
            this.cart = cart;
        }

        public string ID { get { return _ID; } set { _ID = value; } }
        public string Name { get { return _Name; } set { _Name = value; lbl_name.Text = value; } }
        public string Desc { get { return _Description; } set { _Description = value; } }
        public string Quantity { get { return _Quantity; } set { _Quantity = value; lbl_quan.Text = value; } }
        public string Total { get { return _Total; } set { _Total = value; lbl_total.Text = value; } }
        public Image Pic { get { return _Image; } set { _Image = value; pic_item.Image = value; } }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            cart.removeItemFromCart(_ID, Total);
        }
    }
}
