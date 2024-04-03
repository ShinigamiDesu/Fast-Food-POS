namespace FastFoodPOS
{
    partial class cusForm
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
            this.items_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.category_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_categoryname = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_cart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // items_Panel
            // 
            this.items_Panel.AutoScroll = true;
            this.items_Panel.BackColor = System.Drawing.Color.White;
            this.items_Panel.Location = new System.Drawing.Point(180, 104);
            this.items_Panel.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.items_Panel.Name = "items_Panel";
            this.items_Panel.Size = new System.Drawing.Size(470, 722);
            this.items_Panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 68);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(3, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 1);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(242, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food System";
            // 
            // category_Panel
            // 
            this.category_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.category_Panel.Location = new System.Drawing.Point(0, 68);
            this.category_Panel.Name = "category_Panel";
            this.category_Panel.Size = new System.Drawing.Size(179, 758);
            this.category_Panel.TabIndex = 2;
            // 
            // lbl_categoryname
            // 
            this.lbl_categoryname.AutoSize = true;
            this.lbl_categoryname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoryname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_categoryname.Location = new System.Drawing.Point(367, 76);
            this.lbl_categoryname.Name = "lbl_categoryname";
            this.lbl_categoryname.Size = new System.Drawing.Size(72, 25);
            this.lbl_categoryname.TabIndex = 2;
            this.lbl_categoryname.Text = "Meals";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(178, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 748);
            this.panel3.TabIndex = 3;
            // 
            // btn_cart
            // 
            this.btn_cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_cart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cart.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cart.Location = new System.Drawing.Point(182, 76);
            this.btn_cart.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(83, 25);
            this.btn_cart.TabIndex = 5;
            this.btn_cart.Text = "View Cart";
            this.btn_cart.UseVisualStyleBackColor = false;
            this.btn_cart.Visible = false;
            this.btn_cart.Click += new System.EventHandler(this.btn_cart_Click);
            // 
            // cusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 826);
            this.Controls.Add(this.btn_cart);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbl_categoryname);
            this.Controls.Add(this.category_Panel);
            this.Controls.Add(this.items_Panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "cusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.cusForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel items_Panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel category_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_categoryname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_cart;
    }
}