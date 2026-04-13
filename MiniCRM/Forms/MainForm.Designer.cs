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
            dataGridView1 = new DataGridView();
            btnList = new Button();
            txtName = new TextBox();
            txtPhone = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(118, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            // 
            // btnList
            // 
            btnList.Location = new Point(283, 234);
            btnList.Name = "btnList";
            btnList.Size = new Size(75, 23);
            btnList.TabIndex = 1;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(563, 64);
            txtName.Name = "txtName";
            txtName.Size = new Size(189, 23);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(563, 93);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(189, 23);
            txtPhone.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(677, 133);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(190, 234);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(btnList);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnList;
        private TextBox txtName;
        private TextBox txtPhone;
        private Button btnAdd;
        private Button btnDelete;
    }
}