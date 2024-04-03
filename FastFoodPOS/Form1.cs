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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cus_Click(object sender, EventArgs e)
        {
            cusForm cus = new cusForm();
            kitchenForm kitchen = new kitchenForm();
            statusForm status = new statusForm();
            status.Show();
            kitchen.Show();
            cus.Show();
        }

        private void btn_cat_Click(object sender, EventArgs e)
        {
            addCategory cat = new addCategory();
            cat.ShowDialog();
        }

        private void btn_item_Click(object sender, EventArgs e)
        {
            addProduct pro = new addProduct();
            pro.ShowDialog();
        }
    }
}
