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
    public partial class addProduct : Form
    {
        byte[] img;
        DataIO dataIO = new DataIO();

        public addProduct()
        {
            InitializeComponent();
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            DataTable dt = dataIO.getAllCategory();
            combo_category.DataSource = dt;
            combo_category.DisplayMember = "category_Name";
            combo_category.ValueMember = "category_ID";
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            string ImagePath = "";

            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All Files(*.*)|*.*";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = Dialog.FileName.ToString();
                pic_product.ImageLocation = ImagePath;
                byte[] imagebyte = null;
                FileStream fs = new FileStream(ImagePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                imagebyte = br.ReadBytes((int)fs.Length);
                img = imagebyte;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_description.Text == "" || txt_name.Text == "" || txt_price.Text == "" || combo_category.SelectedIndex == -1 || pic_product.Image == null) 
            {
                MessageBox.Show("Fill Everything");
            }
            else 
            {
                int cat = int.Parse(combo_category.SelectedValue.ToString());
                dataIO.addProduct(txt_name.Text, txt_description.Text, txt_price.Text, img, cat);
                lbl_added.Visible = true;
                txt_price.Text = "";
                txt_name.Text = "";
                txt_description.Text = "";
                pic_product.Image = null;
            }
        }

    }
}
