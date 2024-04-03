namespace FastFoodPOS
{
    partial class category
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_name = new System.Windows.Forms.Label();
            this.pic_category = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_category)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_name.Location = new System.Drawing.Point(69, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(54, 19);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Meals";
            // 
            // pic_category
            // 
            this.pic_category.Image = global::FastFoodPOS.Properties.Resources.burger_png_the_eatery_steak_special_16;
            this.pic_category.Location = new System.Drawing.Point(0, 0);
            this.pic_category.Name = "pic_category";
            this.pic_category.Size = new System.Drawing.Size(63, 42);
            this.pic_category.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_category.TabIndex = 0;
            this.pic_category.TabStop = false;
            // 
            // category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pic_category);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Name = "category";
            this.Size = new System.Drawing.Size(180, 42);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.category_MouseClick);
            this.MouseEnter += new System.EventHandler(this.category_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.category_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pic_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_category;
        private System.Windows.Forms.Label lbl_name;
    }
}
