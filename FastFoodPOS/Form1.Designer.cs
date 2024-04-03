namespace FastFoodPOS
{
    partial class Form1
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
            this.btn_cus = new System.Windows.Forms.Button();
            this.btn_item = new System.Windows.Forms.Button();
            this.btn_cat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cus
            // 
            this.btn_cus.Location = new System.Drawing.Point(21, 29);
            this.btn_cus.Name = "btn_cus";
            this.btn_cus.Size = new System.Drawing.Size(147, 23);
            this.btn_cus.TabIndex = 3;
            this.btn_cus.Text = "Open Program";
            this.btn_cus.UseVisualStyleBackColor = true;
            this.btn_cus.Click += new System.EventHandler(this.btn_cus_Click);
            // 
            // btn_item
            // 
            this.btn_item.Location = new System.Drawing.Point(23, 64);
            this.btn_item.Name = "btn_item";
            this.btn_item.Size = new System.Drawing.Size(147, 23);
            this.btn_item.TabIndex = 4;
            this.btn_item.Text = "Add item";
            this.btn_item.UseVisualStyleBackColor = true;
            this.btn_item.Click += new System.EventHandler(this.btn_item_Click);
            // 
            // btn_cat
            // 
            this.btn_cat.Location = new System.Drawing.Point(21, 102);
            this.btn_cat.Name = "btn_cat";
            this.btn_cat.Size = new System.Drawing.Size(147, 23);
            this.btn_cat.TabIndex = 5;
            this.btn_cat.Text = "Add Category";
            this.btn_cat.UseVisualStyleBackColor = true;
            this.btn_cat.Click += new System.EventHandler(this.btn_cat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 151);
            this.Controls.Add(this.btn_cat);
            this.Controls.Add(this.btn_item);
            this.Controls.Add(this.btn_cus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cus;
        private System.Windows.Forms.Button btn_item;
        private System.Windows.Forms.Button btn_cat;
    }
}

