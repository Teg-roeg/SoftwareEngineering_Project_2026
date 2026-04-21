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
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT CUSID FROM Customers";

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
            var confirmResult = MessageBox.Show(
                 "Update Customer's Details?",
                 "Confirmation",
                 MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
                return;


            if (CusIDBox.SelectedItem == null || !(CusIDBox.SelectedItem is DataRowView row))
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

                    string query = @"UPDATE Customers 
                                     SET Name = :name, PhoneNum = :phone 
                                     WHERE CusID = :id";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {

                        cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = nameCusBox.Text;
                        cmd.Parameters.Add(":phone", OracleDbType.Varchar2).Value = numCusBox.Text;
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = cusId;

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            MessageBox.Show("Details updated successfully!");
                        else
                            MessageBox.Show("Customer ID not found.");
                    }

                    nameCusBox.Clear();
                    numCusBox.Clear();
                    CusIDBox.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }


        private void txtCarID_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }



        private void CusIDBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CusIDBox.SelectedValue == null)
                return;

            if (!int.TryParse(CusIDBox.SelectedValue.ToString(), out int cusId))
                return;

            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT Name, PhoneNum FROM Customers WHERE CusID = :id";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = cusId;

                        OracleDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            nameCusBox.Text = reader["Name"].ToString();
                            numCusBox.Text = reader["PhoneNum"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
