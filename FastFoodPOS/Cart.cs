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
    public partial class Cart : Form
    {
        DataIO dataIO = new DataIO();
        private cusForm cus;
        private List<CartItems> cartList;
        decimal totalAMT = 0;

        public Cart(cusForm cus)
        {
            InitializeComponent();
            this.cus = cus;
            cartList = cus.GetCartList();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            loadItems();
        }

        public void loadItems() 
        {
            totalAMT = 0;
            items_Panel.Controls.Clear();
            ItemsCart[] listItems = new ItemsCart[cartList.Count];
            for (int i = 0; i < 1; i++)
            {
                foreach (CartItems item in cartList)
                {
                    decimal priceValue = decimal.Parse(item.Price);
                    int quantityValue = int.Parse(item.Quantity);
                    decimal total = priceValue * quantityValue;
                    string total1 = total.ToString();
                    listItems[i] = new ItemsCart(this);
                    // Adding The Item Picture
                    listItems[i].Pic = item.Image;    
                    // Adding Item ID
                    listItems[i].ID = item.ID;
                    // Adding Item Name
                    listItems[i].Name = item.Name;
                    // Adding Item Price
                    listItems[i].Total = total1;
                    // Adding Item Quantity
                    listItems[i].Quantity = item.Quantity;
                    items_Panel.Controls.Add(listItems[i]);
                    totalAMT = totalAMT + total;
                }
            }
            lbl_total.Text = "AED " + totalAMT.ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if(items_Panel.Controls.Count == 0) 
            {
                cus.setCartVisible(false);
            }
            this.Close();

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int OrderID = random.Next(100000, 1000000);
            dataIO.addOrder(OrderID, totalAMT);
            foreach (CartItems item in cartList)
            {
                int itemID = int.Parse(item.ID);
                int itemQuantity = int.Parse(item.Quantity);
                dataIO.addOrderItems(OrderID, itemID, itemQuantity);
            }
            this.Close();
            cartList.Clear();
            cus.setCartVisible(false);
            cus.loadMeals();
        }

        public void removeItemFromCart(string ID, string price) 
        {
            decimal newPrice = decimal.Parse(price);
            if(items_Panel.Controls.Count == 1) 
            {
                cartList.RemoveAll(item => item.ID == ID);
                cus.setCartVisible(false);
                totalAMT = totalAMT - newPrice;
                this.Close();
            }
            else 
            {
                cartList.RemoveAll(item => item.ID == ID);
                loadItems();
                totalAMT = totalAMT - newPrice;
            }
            
        }
    }
}
