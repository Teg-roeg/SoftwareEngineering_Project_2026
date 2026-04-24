using CarServiceAdministration.DBConnect;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarServiceAdministration
{
    public partial class UpdateService : Form
    {
        public UpdateService()
        {
            InitializeComponent();
        }

        private void UpdateService_Load(object sender, EventArgs e)
        {
            using (OracleConnection con =
         new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT SerID FROM Services";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        OracleDataReader reader = cmd.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        SerIDBox.DataSource = dt;
                        SerIDBox.DisplayMember = "SerID";
                        SerIDBox.ValueMember = "SerID";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Service IDs: " + ex.Message);
                }
            }
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Update Service Job Details?", "Confirmation", MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
                return;

            if (SerIDBox.SelectedItem == null || !(SerIDBox.SelectedItem is DataRowView row))
            {
                MessageBox.Show("Please select a valid Service ID.");
                return;
            }

            string name = nameSerBox.Text.Trim();
            string priceText = priceSerBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || name.Any(char.IsDigit))
            {
                MessageBox.Show("Service name cannot be empty or contain numbers.");
                nameSerBox.Focus();
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Price must be a valid number.");
                priceSerBox.Focus();
                return;
            }

            if (price < 0)
            {
                MessageBox.Show("Price cannot be negative.");
                priceSerBox.Focus();
                return;
            }

            int serId = Convert.ToInt32(row["SerID"]);

            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"UPDATE Services 
                             SET ServiceName = :name, Price = :price 
                             WHERE SerID = :id";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                        cmd.Parameters.Add(":price", OracleDbType.Decimal).Value = price;
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = serId;

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            MessageBox.Show("Details updated successfully!");
                        else
                            MessageBox.Show("Service ID not found.");
                    }

                    nameSerBox.Clear();
                    priceSerBox.Clear();
                    SerIDBox.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void SerIDBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SerIDBox.SelectedItem == null || !(SerIDBox.SelectedItem is DataRowView row))
                return;

            int serId = Convert.ToInt32(row["SerID"]);

            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT ServiceName, Price FROM Services WHERE SerID = :id";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = serId;

                        OracleDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            nameSerBox.Text = reader["ServiceName"].ToString();
                            priceSerBox.Text = reader["Price"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }
    }
}