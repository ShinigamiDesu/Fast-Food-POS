namespace FastFoodPOS
{
    partial class statusForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flow_preparing = new System.Windows.Forms.FlowLayoutPanel();
            this.flow_ready = new System.Windows.Forms.FlowLayoutPanel();
            this.checkStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(352, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 485);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preparing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ready For Collection";
            // 
            // flow_preparing
            // 
            this.flow_preparing.Location = new System.Drawing.Point(4, 70);
            this.flow_preparing.Name = "flow_preparing";
            this.flow_preparing.Size = new System.Drawing.Size(342, 439);
            this.flow_preparing.TabIndex = 3;
            // 
            // flow_ready
            // 
            this.flow_ready.Location = new System.Drawing.Point(359, 70);
            this.flow_ready.Name = "flow_ready";
            this.flow_ready.Size = new System.Drawing.Size(337, 439);
            this.flow_ready.TabIndex = 4;
            // 
            // checkStatusTimer
            // 
            this.checkStatusTimer.Enabled = true;
            this.checkStatusTimer.Interval = 1000;
            this.checkStatusTimer.Tick += new System.EventHandler(this.checkStatusTimer_Tick);
            // 
            // statusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 532);
            this.Controls.Add(this.flow_ready);
            this.Controls.Add(this.flow_preparing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "statusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Status";
            this.Load += new System.EventHandler(this.statusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flow_preparing;
        private System.Windows.Forms.FlowLayoutPanel flow_ready;
        private System.Windows.Forms.Timer checkStatusTimer;
    }
}