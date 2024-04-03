using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodPOS
{
    public partial class statusForm : Form
    {
        DataIO dataIO = new DataIO();
        public statusForm()
        {
            InitializeComponent();
        }

        private void statusForm_Load(object sender, EventArgs e)
        {
            loadOrders();
        }

        public void loadOrders() 
        { 
            DataTable dt = dataIO.getOrders();
            flow_preparing.Controls.Clear();
            flow_ready.Controls.Clear();
            if (dt != null)
            {
                orderStatus[] listItems = new orderStatus[dt.Rows.Count];
                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listItems[i] = new orderStatus();
                        // Adding Order ID
                        listItems[i].ID = row["order_ID"].ToString();;
                        if (row["order_Status"].ToString() == "0")
                        {
                            listItems[i].setBackgroundRed();
                            flow_preparing.Controls.Add(listItems[i]);
                        }
                        else if (row["order_Status"].ToString() == "1") 
                        {
                            listItems[i].setBackgroundGreen();
                            flow_ready.Controls.Add(listItems[i]);
                        } 
                    }
                }
            }
        }

        private void checkStatusTimer_Tick(object sender, EventArgs e)
        {
            loadOrders();
        }
    }
}
