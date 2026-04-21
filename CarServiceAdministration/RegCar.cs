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
using System.Xml.Linq;

namespace CarServiceAdministration
{
    public partial class RegCar : Form
    {
        public RegCar()
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

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Confirm Car's Information?",
                                     "Confirmation",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    try
                    {
                        con.Open();

                        string query = "INSERT INTO Cars (CarID, CusID, RegNum, Brand) " +
                                       "VALUES (:id, :cusid, :regnum, :brand)";

                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {
                            cmd.Parameters.Add(":id", OracleDbType.Int32).Value = Convert.ToInt32(CarIDBox.Text);
                            cmd.Parameters.Add(":cusid", OracleDbType.Int32).Value = Convert.ToInt32(CusIDBox.SelectedValue);
                            cmd.Parameters.Add(":regnum", OracleDbType.Varchar2).Value = txtRegNum.Text;
                            cmd.Parameters.Add(":brand", OracleDbType.Varchar2).Value = txtBrand.Text;

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Car added successfully!");


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

        private void cusBox_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CusID_Click(object sender, EventArgs e)
        {

        }

        private void txtCarID_TextChanged(object sender, EventArgs e)
        {

        }

        private void CusName_Click(object sender, EventArgs e)
        {

        }

        private void txtRegNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void CusPhoneNum_Click(object sender, EventArgs e)
        {

        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }
    }
}
