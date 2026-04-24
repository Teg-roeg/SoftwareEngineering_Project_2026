using CarServiceAdministration.DBConnect;
using System;
using System.Data;
using System.Linq;
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
                DataTable dt = Customer.FindCustomers(""); // this is similair to the listBox but in this instance I have used gridBox instead
                grdCustomers.DataSource = dt;
                grdCustomers.Columns["CusID"].HeaderText = "Customer ID"; // adding titles to the columns
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

            string name = nameCusBox.Text.Trim();
            string phone = numCusBox.Text.Trim();

            if (name.Any(char.IsDigit))
            {
                MessageBox.Show("Name cannot contain numbers.");
                nameCusBox.Focus();
                return;
            }

            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must contain digits only.");
                numCusBox.Focus();
                return;
            }

            if (phone.Length < 10 || phone.Length > 10)
            {
                MessageBox.Show("Phone number cannot be more or less than 10 digits.");
                numCusBox.Focus();
                return;
            }

            var confirmResult = MessageBox.Show("Update Customer's Details?", "Confirmation", MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
                return;

            customer.Name = name;
            customer.PhoneNum = phone;

            customer.UpdateCustomer();

            MessageBox.Show("Customer details updated successfully!");

            nameCusBox.Clear();
            numCusBox.Clear();
            customer = null;

            LoadAllCustomers();
        }

        private void btnSearch_Click(object sender, EventArgs e) 
        { 
            try { 
                string searchName = txtSearch.Text.Trim(); 
                DataTable dt = Customer.FindCustomers(searchName); 
                
                if (dt.Rows.Count == 0) 
                { 
                    MessageBox.Show("No customers found."); 
                    return;
                } 
                
                grdCustomers.DataSource = dt; 
            
            } catch (Exception ex) { 
                MessageBox.Show("Error searching customers: " + ex.Message);
            } 
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) 
        { 
            Form1 menu = new Form1(); 
            menu.Show(); 
            this.Close(); 
        }
    }
}