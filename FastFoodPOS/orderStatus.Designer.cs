namespace FastFoodPOS
{
    partial class orderStatus
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
            this.lbl_orderid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_orderid
            // 
            this.lbl_orderid.AutoSize = true;
            this.lbl_orderid.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderid.Location = new System.Drawing.Point(17, 7);
            this.lbl_orderid.Name = "lbl_orderid";
            this.lbl_orderid.Size = new System.Drawing.Size(91, 30);
            this.lbl_orderid.TabIndex = 2;
            this.lbl_orderid.Text = "993327";
            // 
            // orderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_orderid);
            this.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.Name = "orderStatus";
            this.Size = new System.Drawing.Size(125, 44);
            this.Load += new System.EventHandler(this.preparingOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_orderid;
    }
}
