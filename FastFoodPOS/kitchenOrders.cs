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
    public partial class kitchenOrders : UserControl
    {
        DataIO dataIO = new DataIO();
        private string _ID;
        public string ID { get { return _ID; } set { _ID = value; lbl_id.Text = value; } }
        public kitchenOrders()
        {
            InitializeComponent();
        }

        public void addToListBox(string item) 
        { 
            list_items.Items.Add(item);
        }

        private void btn_ready_Click(object sender, EventArgs e)
        {
            dataIO.UpdateOrder(_ID, 1);
        }

        private void btn_collected_Click(object sender, EventArgs e)
        {
            dataIO.UpdateOrder(_ID, 2);
        }
    }
}
