using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace FastFoodPOS
{
    public partial class cusForm : Form
    {
        DataIO dataIO = new DataIO();
        private List<CartItems> CartList = new List<CartItems>();
        // method to retrieve the cart list
        internal List<CartItems> GetCartList()
        {
            return CartList;
        }


        public cusForm()
        {
            InitializeComponent();
        }

        public void setCartVisible(bool value) 
        { 
            btn_cart.Visible = value;
        }

        private void cusForm_Load(object sender, EventArgs e)
        {
            loadMeals();
            loadCategory();
        }

        public void loadMeals() 
        {
            DataTable dt = dataIO.getMealsCategory();
            items_Panel.Controls.Clear();
            if (dt != null)
            {
                FoodItems[] listItems = new FoodItems[dt.Rows.Count];
                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listItems[i] = new FoodItems(this);
                        // Adding The Item Picture
                        MemoryStream ms = new MemoryStream((byte[])row["item_IMG"]);
                        listItems[i].Pic = new Bitmap(ms);
                        // Adding Item ID
                        listItems[i].ID = row["item_ID"].ToString();
                        // Adding Item Name
                        listItems[i].Name = row["item_Name"].ToString();
                        // Adding Item Price
                        listItems[i].Price = row["item_Price"].ToString();
                        // Adding Item Desc
                        listItems[i].Desc = row["item_Description"].ToString();
                        if (row["item_in_stock"].ToString() == "0")
                        {
                            listItems[i].setStock();
                        }
                        items_Panel.Controls.Add(listItems[i]);
                    }
                }
            }
        }

        public void loadItemsByCategory(DataTable dt)
        {
            items_Panel.Controls.Clear();
            if (dt != null)
            {
                FoodItems[] listItems = new FoodItems[dt.Rows.Count];
                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listItems[i] = new FoodItems(this);
                        // Adding The Item Picture
                        MemoryStream ms = new MemoryStream((byte[])row["item_IMG"]);
                        listItems[i].Pic = new Bitmap(ms);
                        // Adding Item ID
                        listItems[i].ID = row["item_ID"].ToString();
                        // Adding Item Name
                        listItems[i].Name = row["item_Name"].ToString();
                        // Adding Item Price
                        listItems[i].Price = row["item_Price"].ToString();
                        // Adding Item Desc
                        listItems[i].Desc = row["item_Description"].ToString();
                        if (row["item_in_stock"].ToString() == "0")
                        {
                            listItems[i].setStock();
                        }
                        items_Panel.Controls.Add(listItems[i]);
                    }
                }
            }
        }

        public void loadCategory()
        {
            DataTable dt = dataIO.getAllCategory();
            category_Panel.Controls.Clear();
            if (dt != null)
            {
                category[] listItems = new category[dt.Rows.Count];
                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listItems[i] = new category(this);
                        // Adding The Category Picture
                        MemoryStream ms = new MemoryStream((byte[])row["category_IMG"]);
                        listItems[i].Pic = new Bitmap(ms);
                        // Adding Item ID
                        listItems[i].ID = row["category_ID"].ToString();
                        // Adding Item Name
                        listItems[i].Name = row["category_Name"].ToString();
                        category_Panel.Controls.Add(listItems[i]);
                    }
                }
            }
        }

        public void displayCategroy(string ID, string name) 
        {
            lbl_categoryname.Text = name;
            DataTable dt = dataIO.getItemByCategory(ID);
            loadItemsByCategory(dt);
        }

        public void displayItemDetails(string name, string price, Image pic, string desc, string ID) 
        { 
            selectedItem item  = new selectedItem(this);
            item.ID = ID;
            item.Name = name;
            item.Price = price;
            item.Desc = desc;
            item.Pic = pic;
            item.ShowDialog();
        }

        public void addToCart(string name, string price, string desc, string ID, Image img, string quantity) 
        {
            CartList.Add(new CartItems(name, ID, desc , price, img, quantity));
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart(this);
            cart.ShowDialog();
            cart.loadItems();
        }
    }
}
