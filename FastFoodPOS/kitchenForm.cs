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
    public partial class kitchenForm : Form
    {
        DataIO dataIO = new DataIO();
        public kitchenForm()
        {
            InitializeComponent();
        }

        private void kitchenForm_Load(object sender, EventArgs e)
        {
            loadOrderDetails(); 
        }

        public void loadOrderDetails() 
        {

            order_Panel.Controls.Clear();
            DataTable orderDT = dataIO.getOrders();

            foreach (DataRow row in orderDT.Rows)
            {
                // Check if a kitchenOrders user control with the current order ID already exists
                kitchenOrders existingControl = order_Panel.Controls.OfType<kitchenOrders>().FirstOrDefault(c => c.ID == row["order_ID"].ToString());

                // If the control already exists, use it; otherwise, create a new one
                kitchenOrders listItem = existingControl ?? new kitchenOrders();

                if (existingControl == null)
                {
                    listItem.ID = row["order_ID"].ToString();
                    order_Panel.Controls.Add(listItem);
                }

                // Now add the item details to the ListBox
                DataTable itemsDT = dataIO.getOrderDetails(listItem.ID);
                foreach (DataRow item in itemsDT.Rows)
                {
                    listItem.addToListBox(item["item_Name"].ToString() + " (" + item["item_Quantity"].ToString() + ")");
                }
            }
        }

        private void loadNewOrders_Tick(object sender, EventArgs e)
        {
            loadOrderDetails();
        }
    }
}





// Draft Code


//order_Panel.Controls.Clear();
//for (int i = 0; i < 1; i++)
//{
//    DataTable orderDT = dataIO.getOrders();

//    foreach (DataRow row in orderDT.Rows)
//    {
//        DataTable itemsDT = dataIO.getOrderDetails(row["order_ID"].ToString());
//        kitchenOrders[] listItems = new kitchenOrders[itemsDT.Rows.Count];
//        for (int j = 0; j < listItems.Length; j++)
//        {
//            listItems[j] = new kitchenOrders();
//            listItems[j].ID = row["order_ID"].ToString();
//            foreach (DataRow item in itemsDT.Rows)
//            {
//                listItems[j].addToListBox(item["item_Name"].ToString() + " (" + item["item_Quantity"].ToString() + ")");
//                order_Panel.Controls.Add(listItems[j]);
//            }
//        }
//    }

//}
