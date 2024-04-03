namespace FastFoodPOS
{
    partial class selectedItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_description = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.btn_descrease = new System.Windows.Forms.Button();
            this.btn_increase = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pic_item = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_item)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.lbl_price);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_quantity);
            this.panel1.Controls.Add(this.btn_descrease);
            this.panel1.Controls.Add(this.btn_increase);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.pic_item);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 450);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbl_description);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(132, 260);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(239, 51);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.Black;
            this.lbl_description.Location = new System.Drawing.Point(3, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(206, 38);
            this.lbl_description.TabIndex = 8;
            this.lbl_description.Text = "Burger, with fries, 2 patties and cheese";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(9, 9);
            this.btn_back.Margin = new System.Windows.Forms.Padding(0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 25);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "←";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.Black;
            this.lbl_price.Location = new System.Drawing.Point(217, 199);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(76, 19);
            this.lbl_price.TabIndex = 13;
            this.lbl_price.Text = "RM 12.90";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(194, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quantity";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(198, 344);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.ReadOnly = true;
            this.txt_quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_quantity.TabIndex = 11;
            this.txt_quantity.Text = "1";
            // 
            // btn_descrease
            // 
            this.btn_descrease.Location = new System.Drawing.Point(304, 356);
            this.btn_descrease.Name = "btn_descrease";
            this.btn_descrease.Size = new System.Drawing.Size(27, 33);
            this.btn_descrease.TabIndex = 10;
            this.btn_descrease.Text = "-";
            this.btn_descrease.UseVisualStyleBackColor = true;
            this.btn_descrease.Click += new System.EventHandler(this.btn_descrease_Click);
            // 
            // btn_increase
            // 
            this.btn_increase.Location = new System.Drawing.Point(304, 317);
            this.btn_increase.Name = "btn_increase";
            this.btn_increase.Size = new System.Drawing.Size(27, 33);
            this.btn_increase.TabIndex = 9;
            this.btn_increase.Text = "+";
            this.btn_increase.UseVisualStyleBackColor = true;
            this.btn_increase.Click += new System.EventHandler(this.btn_increase_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(174, 402);
            this.btn_add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(173, 25);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add To Cart";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(122, 226);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lbl_name.Size = new System.Drawing.Size(241, 19);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Double Cheese Burger meal";
            // 
            // pic_item
            // 
            this.pic_item.Image = global::FastFoodPOS.Properties.Resources.burger_png_the_eatery_steak_special_16;
            this.pic_item.Location = new System.Drawing.Point(132, 12);
            this.pic_item.Name = "pic_item";
            this.pic_item.Size = new System.Drawing.Size(239, 211);
            this.pic_item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_item.TabIndex = 5;
            this.pic_item.TabStop = false;
            // 
            // selectedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "selectedItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm item";
            this.Load += new System.EventHandler(this.selectedItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pic_item;
        private System.Windows.Forms.Button btn_descrease;
        private System.Windows.Forms.Button btn_increase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}