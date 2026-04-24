using CarServiceAdministration.DBConnect;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Linq;
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
            // Load customer ids into the combobox
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
            string carIdText = CarIDBox.Text.Trim();
            string regNum = txtRegNum.Text.Trim();
            string brand = txtBrand.Text.Trim();
            string model = txtModel.Text.Trim();
            string yearText = txtYear.Text.Trim();

            if (!int.TryParse(carIdText, out int carId))
            {
                MessageBox.Show("Car ID must be a number.");
                CarIDBox.Focus();
                return;
            }

            if (CusIDBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a Customer ID.");
                return;
            }

            if (string.IsNullOrWhiteSpace(regNum))
            {
                MessageBox.Show("Registration number cannot be empty.");
                txtRegNum.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(brand) || brand.Any(char.IsDigit))
            {
                MessageBox.Show("Brand cannot be empty or contain numbers.");
                txtBrand.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(model) || model.Any(char.IsDigit))
            {
                MessageBox.Show("Model cannot be empty or contain numbers.");
                txtModel.Focus();
                return;
            }

            if (!int.TryParse(yearText, out int year))
            {
                MessageBox.Show("Year must be a number.");
                txtYear.Focus();
                return;
            }

            if (year < 1900 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Year is not valid.");
                txtYear.Focus();
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

                    string query = @"INSERT INTO Cars (CarID, CusID, RegNumber, Brand, Model, Year)
                             VALUES (:id, :cusid, :regnum, :brand, :model, :year)";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = carId;
                        cmd.Parameters.Add(":cusid", OracleDbType.Int32).Value = Convert.ToInt32(CusIDBox.SelectedValue);
                        cmd.Parameters.Add(":regnum", OracleDbType.Varchar2).Value = regNum;
                        cmd.Parameters.Add(":brand", OracleDbType.Varchar2).Value = brand;
                        cmd.Parameters.Add(":model", OracleDbType.Varchar2).Value = model;
                        cmd.Parameters.Add(":year", OracleDbType.Int32).Value = year;

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Car added successfully!");

                    CarIDBox.Clear();
                    txtRegNum.Clear();
                    txtBrand.Clear();
                    txtModel.Clear();
                    txtYear.Clear();
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