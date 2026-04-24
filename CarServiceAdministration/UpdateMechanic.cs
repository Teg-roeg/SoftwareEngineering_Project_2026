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
            InitializeComponent(); // starts the form
        }

        private void UpdateMechanic_Load(object sender, EventArgs e)
        {
            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT MechID FROM Mechanics";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        OracleDataReader reader = cmd.ExecuteReader(); // Executes query and returns results row by row

                        DataTable dt = new DataTable(); // In memory table
                        dt.Load(reader); // loads rows from the reader into that table

                        MechIDBox.DataSource = dt; // combo box assigned as that table
                        MechIDBox.DisplayMember = "MechID"; // name of text
                        MechIDBox.ValueMember = "MechID"; // name of variable
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
            var confirmResult = MessageBox.Show("Update Mechanic's Details?", "Confirmation", MessageBoxButtons.YesNo); // variable to have validation as user pressed yes or no

            if (confirmResult != DialogResult.Yes) // user have pressed no
                return;

            if (MechIDBox.SelectedItem == null || !(MechIDBox.SelectedItem is DataRowView row)) // if selected id of mechanic doesn't existt or value is a null
            {
                MessageBox.Show("Please select a valid Mechanic ID.");
                return;
            }

            string name = nameMechBox.Text.Trim();
            string phone = numMechBox.Text.Trim();

            if (name.Any(char.IsDigit)) // check if name contains digits
            {
                MessageBox.Show("Name cannot contain numbers.");
                nameMechBox.Focus();
                return;
            }

            if (!phone.All(char.IsDigit)) // checks if phone contains letters
            {
                MessageBox.Show("Phone number must contain digits only.");
                numMechBox.Focus();
                return;
            }

            if (phone.Length < 10 || phone.Length > 10) // checks the lenght on phone value
            {
                MessageBox.Show("Phone number cannot be more or less than 10 digits.");
                numMechBox.Focus();
                return;
            }

            int mechId = Convert.ToInt32(row["MechID"]); // get selected id from row and converts to integer

            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"UPDATE Mechanics 
                             SET Name = :name, PhoneNum = :phone 
                             WHERE MechID = :id";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                        cmd.Parameters.Add(":phone", OracleDbType.Varchar2).Value = phone;
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = mechId;

                        int rows = cmd.ExecuteNonQuery(); // executes query

                        if (rows > 0)
                            MessageBox.Show("Details updated successfully!"); // rows updated
                        else
                            MessageBox.Show("Mechanic ID not found."); // no rows updated
                    }

                    nameMechBox.Clear(); // clears textboxes
                    numMechBox.Clear();
                    MechIDBox.Focus(); // focus on first textbox in UI
                }
                catch (Exception ex) // Exception errors
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }
        private void MechIDBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MechIDBox.SelectedItem == null || MechIDBox.SelectedItem is DataRowView == false) 
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

                        if (reader.Read()) // Checks if rows exist
                        {
                            nameMechBox.Text = reader["Name"].ToString(); // set the textbox Namee
                            numMechBox.Text = reader["PhoneNum"].ToString(); // set the textbox PhoneNum
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1(); // back to menu
            menu.Show();
            this.Close();
        }
    }
}
