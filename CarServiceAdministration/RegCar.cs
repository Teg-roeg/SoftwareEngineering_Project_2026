using CarServiceAdministration.DBConnect;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceAdministration
{
    public partial class RegCar : Form
    {
        public RegCar()
        {
            InitializeComponent();
        }

        private void RegCar_Load(object sender, EventArgs e)
        {
            // Load customer IDs into the ComboBox
            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT CusID FROM Customers ORDER BY CusID";
                    DataTable dt = new DataTable();

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        OracleDataReader reader = cmd.ExecuteReader();
                        dt.Load(reader);
                        CusIDBox.DataSource = dt;
                        CusIDBox.DisplayMember = "CusID";
                        CusIDBox.ValueMember = "CusID";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Customer IDs: " + ex.Message);
                }
            }
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CarIDBox.Text) ||
                string.IsNullOrWhiteSpace(txtRegNum.Text) ||
                string.IsNullOrWhiteSpace(txtBrand.Text) ||
                CusIDBox.SelectedValue == null)
            {
                MessageBox.Show("Please fill in all fields and select a Customer ID.");
                return;
            }

            var confirmResult = MessageBox.Show("Confirm Car's Information?",
                                     "Confirmation",
                                     MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
                return;

            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"INSERT INTO Cars (CarID, CusID, RegNumber, Brand)
                                     VALUES (:id, :cusid, :regnum, :brand)";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = Convert.ToInt32(CarIDBox.Text);
                        cmd.Parameters.Add(":cusid", OracleDbType.Int32).Value = Convert.ToInt32(CusIDBox.SelectedValue);
                        cmd.Parameters.Add(":regnum", OracleDbType.Varchar2).Value = txtRegNum.Text.Trim();
                        cmd.Parameters.Add(":brand", OracleDbType.Varchar2).Value = txtBrand.Text.Trim();

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Car added successfully!");

                    // Clear inputs
                    CarIDBox.Clear();
                    txtRegNum.Clear();
                    txtBrand.Clear();
                    CusIDBox.Focus();
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
    }
}