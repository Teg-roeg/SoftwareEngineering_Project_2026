using CarServiceAdministration.DBConnect;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceAdministration
{
    public partial class RegCustomer : Form
    {
        public RegCustomer()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string idText = txtCusID.Text.Trim();

            if (!int.TryParse(idText, out int cusId))
            {
                MessageBox.Show("Customer ID must be a number."); // if customer id contains letters
                txtCusID.Focus();
                return;
            }

            if (name.Any(char.IsDigit))
            {
                MessageBox.Show("Name cannot contain numbers."); // if name contains any digits
                txtName.Focus();
                return;
            }

            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must contain digits only."); // if phone contains any letters
                txtPhone.Focus();
                return;
            }

            if (phone.Length < 10 || phone.Length > 10)
            {
                MessageBox.Show("Phone number cannot be more or less than 10 digits."); // if the phone is less or more than 10 characters long
                txtPhone.Focus();
                return;
            }

            var confirmResult = MessageBox.Show("Confirm Customer's Information?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    try
                    {
                        con.Open();

                        string query = "INSERT INTO Customers (CusID, Name, PhoneNum) " +
                                       "VALUES (:id, :name, :phone)";

                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {
                            cmd.Parameters.Add(":id", OracleDbType.Int32).Value = cusId;
                            cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                            cmd.Parameters.Add(":phone", OracleDbType.Varchar2).Value = phone;

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Customer added successfully!");

                        txtCusID.Clear();
                        txtName.Clear();
                        txtPhone.Clear();
                        txtCusID.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
