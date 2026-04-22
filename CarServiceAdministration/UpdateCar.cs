using CarServiceAdministration.DBConnect;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceAdministration
{
    public partial class UpdateCar : Form
    {
        private DataRow selectedCar;

        public UpdateCar()
        {
            InitializeComponent();
        }

        private void UpdateCar_Load(object sender, EventArgs e)
        {
            LoadAllCars();
        }

        private void LoadAllCars()
        {
            try
            {
                using (OracleConnection con =
                    new OracleConnection(Database.connectionString))
                {
                    con.Open();

                    string query =
                        "SELECT CarID, CusID, RegNumber, Brand, Model, Year FROM Cars";

                    using (OracleDataAdapter da = new OracleDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        grdCars.DataSource = dt;

                        grdCars.Columns["CarID"].HeaderText = "Car ID";
                        grdCars.Columns["CusID"].HeaderText = "Customer ID";
                        grdCars.Columns["RegNumber"].HeaderText = "Registration";
                        grdCars.Columns["Brand"].HeaderText = "Brand";
                        grdCars.Columns["Model"].HeaderText = "Model";
                        grdCars.Columns["Year"].HeaderText = "Year";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cars: " + ex.Message);
            }
        }

        private void grdCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedCar =
                ((DataRowView)grdCars.Rows[e.RowIndex].DataBoundItem).Row;

            regNumBox.Text = selectedCar["RegNumber"].ToString();
            brandBox.Text = selectedCar["Brand"].ToString();
            modelBox.Text = selectedCar["Model"].ToString();
            yearBox.Text = selectedCar["Year"].ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection con =
                    new OracleConnection(Database.connectionString))
                {
                    con.Open();

                    string query;

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;

                    if (string.IsNullOrWhiteSpace(txtSearch.Text))
                    {
                        query = "SELECT CarID, CusID, RegNumber, Brand, Model, Year FROM Cars";
                    }
                    else
                    {
                        query = "SELECT CarID, CusID, RegNumber, Brand, Model, Year " +
                                "FROM Cars WHERE CusID = :id";

                        cmd.Parameters.Add(":id", OracleDbType.Int32)
                            .Value = Convert.ToInt32(txtSearch.Text.Trim());
                    }

                    cmd.CommandText = query;

                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No customer found.");
                            return;
                        }

                        grdCars.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            if (selectedCar == null)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }

            var confirmResult = MessageBox.Show(
                "Update Car's Details?",
                "Confirmation",
                MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                using (OracleConnection con =
                    new OracleConnection(Database.connectionString))
                {
                    con.Open();

                    string query =
                        "UPDATE Cars SET " +
                        "RegNumber = :regnum, " +
                        "Brand = :brand, " +
                        "Model = :model, " +
                        "Year = :year " +
                        "WHERE CarID = :id";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":regnum", OracleDbType.Varchar2).Value =
                            regNumBox.Text;

                        cmd.Parameters.Add(":brand", OracleDbType.Varchar2).Value =
                            brandBox.Text;

                        cmd.Parameters.Add(":model", OracleDbType.Varchar2).Value =
                            modelBox.Text;

                        cmd.Parameters.Add(":year", OracleDbType.Int32).Value =
                            Convert.ToInt32(yearBox.Text);

                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value =
                            selectedCar["CarID"];

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Car updated successfully!");

                regNumBox.Clear();
                brandBox.Clear();
                modelBox.Clear();
                yearBox.Clear();

                selectedCar = null;

                LoadAllCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
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