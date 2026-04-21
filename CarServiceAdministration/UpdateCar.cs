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
    public partial class UpdateCar : Form
    {
        public UpdateCar()
        {
            InitializeComponent();
        }
        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            using (OracleConnection con =
         new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT CusID FROM Customers";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        OracleDataReader reader = cmd.ExecuteReader();

                        DataTable dt = new DataTable();
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

        private void UpdateCar_Load(object sender, EventArgs e)
        {
            using (OracleConnection con =
         new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT CarID FROM Cars";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        OracleDataReader reader = cmd.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        CarIDBox.DataSource = dt;
                        CarIDBox.DisplayMember = "CarID";
                        CarIDBox.ValueMember = "CarID";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Car IDs: " + ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Update Car's Details?",
                        "Confirmation",
                        MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    try
                    {
                        con.Open();

                        string query = "UPDATE Cars " +
                                       "SET CusID = :cusid, RegNumber = :regnum, Brand = :brand, Model = :model, Year = :year " +
                                       "WHERE CarID = :id";

                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {
                            cmd.Parameters.Add(":id", OracleDbType.Int32).Value = Convert.ToInt32(CarIDBox.SelectedValue);
                            cmd.Parameters.Add(":cusid", OracleDbType.Int32).Value = Convert.ToInt32(CusIDBox.SelectedValue);
                            cmd.Parameters.Add(":regnum", OracleDbType.Varchar2).Value = regNumBox.Text;
                            cmd.Parameters.Add(":brand", OracleDbType.Varchar2).Value = brandBox.Text;
                            cmd.Parameters.Add(":model", OracleDbType.Varchar2).Value = modelBox.Text;
                            cmd.Parameters.Add(":year", OracleDbType.Int32).Value = Convert.ToInt32(yearBox.Text);

                            int rows = cmd.ExecuteNonQuery();

                            if (rows > 0)
                                MessageBox.Show("Details updated successfully!");
                            else
                                MessageBox.Show("Car ID not found.");
                        }

                        regNumBox.Clear();
                        brandBox.Clear();
                        modelBox.Clear();
                        yearBox.Clear();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCarID_TextChanged(object sender, EventArgs e)
        {
            if (CarIDBox.SelectedValue == null) return;

            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT CusID, RegNum, Brand, Model, Year FROM Cars WHERE CarID = :id";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":id", OracleDbType.Int32)
                           .Value = Convert.ToInt32(CarIDBox.SelectedValue);

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CusIDBox.SelectedValue = reader["CusID"];
                                regNumBox.Text = reader["RegNum"].ToString();
                                brandBox.Text = reader["Brand"].ToString();
                                modelBox.Text = reader["Model"].ToString();
                                yearBox.Text = reader["Year"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading car details: " + ex.Message);
                }
            }
        }
    }
}
