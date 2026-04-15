namespace MiniCRM.Forms
{
    partial class MainForm
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
            btnCustomer = new Button();
            btnOrder = new Button();
            SuspendLayout();
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(92, 78);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(270, 23);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Customer Page";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(92, 129);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(270, 23);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "Order Page";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOrder);
            Controls.Add(btnCustomer);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCustomer;
        private Button btnOrder;
    }
}