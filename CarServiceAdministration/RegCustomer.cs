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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {


        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name cannot contain numbers.");
                txtName.Focus();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Confirm Customer's Information?",
                                     "Confirmation",
                                     MessageBoxButtons.YesNo);
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
                            cmd.Parameters.Add(":id", OracleDbType.Int32).Value = Convert.ToInt32(txtCusID.Text);
                            cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = txtName.Text;
                            cmd.Parameters.Add(":phone", OracleDbType.Varchar2).Value = txtPhone.Text;

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

        private void txtCusID_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
