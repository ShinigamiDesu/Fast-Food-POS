namespace FastFoodPOS
{
    partial class kitchenOrders
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ready = new System.Windows.Forms.Button();
            this.btn_collected = new System.Windows.Forms.Button();
            this.list_items = new System.Windows.Forms.ListBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Items:";
            // 
            // btn_ready
            // 
            this.btn_ready.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ready.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ready.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ready.ForeColor = System.Drawing.Color.White;
            this.btn_ready.Location = new System.Drawing.Point(3, 222);
            this.btn_ready.Name = "btn_ready";
            this.btn_ready.Size = new System.Drawing.Size(119, 25);
            this.btn_ready.TabIndex = 2;
            this.btn_ready.Text = "Ready";
            this.btn_ready.UseVisualStyleBackColor = false;
            this.btn_ready.Click += new System.EventHandler(this.btn_ready_Click);
            // 
            // btn_collected
            // 
            this.btn_collected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_collected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_collected.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_collected.Location = new System.Drawing.Point(128, 222);
            this.btn_collected.Name = "btn_collected";
            this.btn_collected.Size = new System.Drawing.Size(119, 25);
            this.btn_collected.TabIndex = 3;
            this.btn_collected.Text = "Collected";
            this.btn_collected.UseVisualStyleBackColor = false;
            this.btn_collected.Click += new System.EventHandler(this.btn_collected_Click);
            // 
            // list_items
            // 
            this.list_items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_items.FormattingEnabled = true;
            this.list_items.Location = new System.Drawing.Point(7, 63);
            this.list_items.Name = "list_items";
            this.list_items.Size = new System.Drawing.Size(240, 143);
            this.list_items.TabIndex = 4;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_id.Location = new System.Drawing.Point(73, 9);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(45, 19);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "5978";
            // 
            // kitchenOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.list_items);
            this.Controls.Add(this.btn_collected);
            this.Controls.Add(this.btn_ready);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "kitchenOrders";
            this.Size = new System.Drawing.Size(251, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ready;
        private System.Windows.Forms.Button btn_collected;
        private System.Windows.Forms.ListBox list_items;
        private System.Windows.Forms.Label lbl_id;
    }
}
