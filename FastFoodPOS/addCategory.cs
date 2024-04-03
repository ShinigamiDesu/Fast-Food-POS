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
    public partial class addCategory : Form
    {
        byte[] img;
        DataIO dataIO = new DataIO();    

        public addCategory()
        {
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            string ImagePath = "";

            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All Files(*.*)|*.*";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = Dialog.FileName.ToString();
                pic_category.ImageLocation = ImagePath;
                byte[] imagebyte = null;
                FileStream fs = new FileStream(ImagePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                imagebyte = br.ReadBytes((int)fs.Length);
                img = imagebyte;
            }
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_name.Text == "" || pic_category.Image == null) 
            {
                MessageBox.Show("Fill Everything.");
            }
            else 
            {
                dataIO.addCategory(txt_name.Text, img);
                txt_name.Text = "";
                pic_category.Image = null;
                lbl_added.Visible = true;
            }
        }
    }
}
