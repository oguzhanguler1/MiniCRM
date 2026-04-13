using MiniCRM.Models;
using MiniCRM.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiniCRM.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var service = new CustomerService();
            var customers = service.GetAll();

            dataGridView1.DataSource = customers;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
                return;
            }






            var customer = new Customer
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
            };

            var customerService = new CustomerService();

            customerService.Add(customer);



            dataGridView1.DataSource = customerService.GetAll();


            txtName.Text = "";
            txtPhone.Text = "";


            MessageBox.Show("Customer Added");



        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select to delete customer");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            var service = new CustomerService();
            service.Delete(id);

            dataGridView1.DataSource = service.GetAll();

            MessageBox.Show("Customer Deleted");



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Lütfen bir müşteri seçin ve alanları doldurun");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            var customer = new Customer
            {
                Id = id,
                Name = txtName.Text,
                Phone = txtPhone.Text
            };

            var service = new CustomerService();
            service.Update(customer);

            dataGridView1.DataSource = service.GetAll();

            txtName.Text = "";
            txtPhone.Text = "";

            MessageBox.Show("Müşteri güncellendi");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value?.ToString() ?? "";
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value?.ToString() ?? "";
        }
    }
}
