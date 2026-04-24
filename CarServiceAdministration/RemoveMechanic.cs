using CarServiceAdministration.DBConnect;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceAdministration
{
    public partial class RemoveMechanic : Form
    {
        public RemoveMechanic()
        {
            InitializeComponent();
        }

        private void RemoveMechanic_Load(object sender, EventArgs e)
        {
            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT MechID, Name, PhoneNum FROM Mechanics";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());

                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "MechID";
                        comboBox1.ValueMember = "MechID";
                        comboBox1.SelectedIndex = -1; // clears selection 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customers: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || !(comboBox1.SelectedItem is DataRowView row)) // checks is selected item is not exist in datarow or null
                return;

            listMechBox.Items.Clear();

            listMechBox.Items.Add("Mechanic Id: " + row["MechID"]); // Item appears in listBox
            listMechBox.Items.Add("Mechanic Name: " + row["Name"]);
            listMechBox.Items.Add("Phone Number: " + row["PhoneNum"]);
        }

        private void AddMechanic_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to remove data?","Confirmation",MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
                return;

            if (comboBox1.SelectedItem == null || !(comboBox1.SelectedItem is DataRowView row))
            {
                MessageBox.Show("Please select a valid Mechanic ID.");
                return;
            }

            int mechId = Convert.ToInt32(row["MechID"]);

            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "DELETE FROM Mechanics WHERE MechID = :id";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = mechId;

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                            MessageBox.Show("Mechanic Removed Successfully");
                        else
                            MessageBox.Show("Mechanic not found.");
                    }

                    listMechBox.Items.Clear(); // clears items in listBox after removal
                    comboBox1.SelectedIndex = -1; // resets selection, no item is selected
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to cancel?","Confirmation",MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes) // whole code just cancel the selection
                return;

            comboBox1.SelectedIndex = -1;
            listMechBox.Items.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }
    }
}
