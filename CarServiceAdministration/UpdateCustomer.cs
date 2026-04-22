using CarServiceAdministration.DBConnect;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceAdministration
{
    public partial class UpdateCustomer : Form
    {
        private Customer customer; 

        public UpdateCustomer()
        {
            InitializeComponent();
        }
        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            LoadAllCustomers();
        }

        private void LoadAllCustomers()
        {
            try
            {
                DataTable dt = Customer.FindCustomers("");
                grdCustomers.DataSource = dt;
                grdCustomers.Columns["CusID"].HeaderText = "Customer ID";
                grdCustomers.Columns["Name"].HeaderText = "Name";
                grdCustomers.Columns["PhoneNum"].HeaderText = "Phone Number";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
        }

        private void grdCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 

            int cusId = Convert.ToInt32(grdCustomers.Rows[e.RowIndex].Cells["CusID"].Value);
            customer = Customer.GetCustomer(cusId);

            if (customer != null)
            {
                nameCusBox.Text = customer.Name;
                numCusBox.Text = customer.PhoneNum;
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (customer == null)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }

            var confirmResult = MessageBox.Show("Update Customer's Details?", "Confirmation",MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
                return;

            customer.Name = nameCusBox.Text;
            customer.PhoneNum = numCusBox.Text;

            customer.UpdateCustomer();

            MessageBox.Show("Customer details updated successfully!");

            nameCusBox.Clear();
            numCusBox.Clear();
            customer = null;

            LoadAllCustomers(); 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchName = txtSearch.Text.Trim();
                DataTable dt = Customer.FindCustomers(searchName);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No customers found.");
                    return;
                }

                grdCustomers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching customers: " + ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void grdCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cusIDBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grdCustomers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}