using CarServiceAdministration.DBConnect;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CarServiceAdministration
{
    public partial class RegService : Form
    {
        public RegService()
        {
            InitializeComponent();
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            string idText = SerIDBox.Text.Trim();
            string name = numSerBox.Text.Trim();
            string priceText = txtPrice.Text.Trim();

            if (!int.TryParse(idText, out int serId))
            {
                MessageBox.Show("Service ID must be a number.");
                SerIDBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(name) || name.Any(char.IsDigit))
            {
                MessageBox.Show("Service name cannot be empty or contain numbers.");
                numSerBox.Focus();
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Price must be a valid number.");
                txtPrice.Focus();
                return;
            }

            if (price < 0)
            {
                MessageBox.Show("Price cannot be negative.");
                txtPrice.Focus();
                return;
            }

            var confirmResult = MessageBox.Show("Confirm Service Job Information?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    try
                    {
                        con.Open();

                        string query = "INSERT INTO Services (SerID, ServiceName, Price) " +
                                       "VALUES (:id, :name, :price)";

                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {
                            cmd.Parameters.Add(":id", OracleDbType.Int32).Value = serId;
                            cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                            cmd.Parameters.Add(":price", OracleDbType.Decimal).Value = price;

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Service Job added successfully!");

                        SerIDBox.Clear();
                        numSerBox.Clear();
                        txtPrice.Clear();
                        SerIDBox.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message);
                    }
                }
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
