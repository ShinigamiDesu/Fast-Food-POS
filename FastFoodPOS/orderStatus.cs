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
    public partial class orderStatus : UserControl
    {

        private string _ID;
        public string ID { get { return _ID; } set { _ID = value; lbl_orderid.Text = value; } }


        public orderStatus()
        {
            InitializeComponent();
        }

        private void preparingOrder_Load(object sender, EventArgs e)
        {

        }

        public void setBackgroundGreen() 
        {
            this.BackColor = Color.Lime;
        }

        public void setBackgroundRed()
        {
            this.BackColor = Color.Red;
        }
    }
}
