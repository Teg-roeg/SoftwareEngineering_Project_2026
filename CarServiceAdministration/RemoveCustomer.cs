using CarServiceAdministration.DBConnect;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceAdministration
{
    public partial class RemoveCustomer : Form
    {
        public RemoveCustomer()
        {
            InitializeComponent();
        }

        // LOAD DATA INTO COMBOBOX
        private void RemoveCustomer_Load(object sender, EventArgs e)
        {
            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT CusID, Name, PhoneNum FROM Customers";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());

                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "CusID";
                        comboBox1.ValueMember = "CusID";
                        comboBox1.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customers: " + ex.Message);
                }
            }
        }

        // SHOW SELECTED CUSTOMER DETAILS
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || !(comboBox1.SelectedItem is DataRowView row))
                return;

            listCusBox.Items.Clear();

            listCusBox.Items.Add("Customer Id: " + row["CusID"]);
            listCusBox.Items.Add("Customer Name: " + row["Name"]);
            listCusBox.Items.Add("Phone Number: " + row["PhoneNum"]);
        }

        // REMOVE CUSTOMER
        private void RmvCustomer_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Are you sure you want to remove data?",
                "Confirmation",
                MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
                return;

            if (comboBox1.SelectedItem == null || !(comboBox1.SelectedItem is DataRowView row))
            {
                MessageBox.Show("Please select a valid Customer ID.");
                return;
            }

            int cusId = Convert.ToInt32(row["CusID"]);

            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "DELETE FROM Customers WHERE CusID = :id";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = cusId;

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                            MessageBox.Show("Customer Removed Successfully");
                        else
                            MessageBox.Show("Customer not found.");
                    }

                    listCusBox.Items.Clear();
                    comboBox1.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        // CANCEL BUTTON (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Are you sure you want to cancel?",
                "Confirmation",
                MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
                return;

            comboBox1.SelectedIndex = -1;
            listCusBox.Items.Clear();
        }

        // EXIT
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }
    }
}