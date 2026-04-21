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
    public partial class UpdateMechanic : Form
    {
        public UpdateMechanic()
        {
            InitializeComponent();
        }

        private void UpdateMechanic_Load(object sender, EventArgs e)
        {
            using (OracleConnection con =
         new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT MechID FROM Mechanics";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        OracleDataReader reader = cmd.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        MechIDBox.DataSource = dt;
                        MechIDBox.DisplayMember = "MechID";
                        MechIDBox.ValueMember = "MechID";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Mechanic IDs: " + ex.Message);
                }
            }
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                 "Update Mechanic's Details?",
                 "Confirmation",
                 MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
                return;

            // Safe ID retrieval
            if (MechIDBox.SelectedItem == null ||
                !(MechIDBox.SelectedItem is DataRowView row))
            {
                MessageBox.Show("Please select a valid Mechanic ID.");
                return;
            }

            int mechId = Convert.ToInt32(row["MechID"]);

            using (OracleConnection con =
                new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"UPDATE Mechanics 
                                     SET Name = :name, PhoneNum = :phone 
                                     WHERE MechID = :id";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        // IMPORTANT: Order matters in Oracle
                        cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = nameMechBox.Text;
                        cmd.Parameters.Add(":phone", OracleDbType.Varchar2).Value = numMechBox.Text;
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = mechId;

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            MessageBox.Show("Details updated successfully!");
                        else
                            MessageBox.Show("Mechanic ID not found.");
                    }

                    nameMechBox.Clear();
                    numMechBox.Clear();
                    MechIDBox.Focus();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MechIDBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MechIDBox.SelectedItem == null ||
                MechIDBox.SelectedItem is DataRowView == false)
                return;

            DataRowView row = (DataRowView)MechIDBox.SelectedItem;

            int mechId = Convert.ToInt32(row["MechID"]);

            using (OracleConnection con =
                new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT Name, PhoneNum FROM Mechanics WHERE MechID = :id";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = mechId;

                        OracleDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            nameMechBox.Text = reader["Name"].ToString();
                            numMechBox.Text = reader["PhoneNum"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void txtCarID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void CusID_Click(object sender, EventArgs e)
        {

        }

        private void CusName_Click(object sender, EventArgs e)
        {

        }

        private void txtRegNum_TextChanged(object sender, EventArgs e)
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
