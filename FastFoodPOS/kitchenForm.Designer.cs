namespace FastFoodPOS
{
    partial class kitchenForm
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
            this.components = new System.ComponentModel.Container();
            this.order_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.loadNewOrders = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // order_Panel
            // 
            this.order_Panel.AutoScroll = true;
            this.order_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.order_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_Panel.Location = new System.Drawing.Point(0, 0);
            this.order_Panel.Name = "order_Panel";
            this.order_Panel.Size = new System.Drawing.Size(789, 492);
            this.order_Panel.TabIndex = 1;
            // 
            // loadNewOrders
            // 
            this.loadNewOrders.Enabled = true;
            this.loadNewOrders.Interval = 3000;
            this.loadNewOrders.Tick += new System.EventHandler(this.loadNewOrders_Tick);
            // 
            // kitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 492);
            this.Controls.Add(this.order_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kitchenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kitchenForm";
            this.Load += new System.EventHandler(this.kitchenForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel order_Panel;
        private System.Windows.Forms.Timer loadNewOrders;
    }
}