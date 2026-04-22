using CarServiceAdministration.DBConnect;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceAdministration
{
    public partial class RemoveCar : Form
    {
        public RemoveCar()
        {
            InitializeComponent();
        }

        // LOAD FORM
        private void RemoveCar_Load(object sender, EventArgs e)
        {
            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT CarID, CusID, RegNumber, Brand, Model, Year FROM Cars";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());

                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "CarID";
                        comboBox1.ValueMember = "CarID";
                        comboBox1   .SelectedIndex = -1; // no selection at start
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading cars: " + ex.Message);
                }
            }
        }

        private void CarIDBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || !(comboBox1.SelectedItem is DataRowView row))
                return;

            listCarBox.Items.Clear();

            listCarBox.Items.Add("Car Id: " + row["CarID"]);
            listCarBox.Items.Add("Customer Id: " + row["CusID"]);
            listCarBox.Items.Add("Registration Number: " + row["RegNumber"]);
            listCarBox.Items.Add("Brand: " + row["Brand"]);
            listCarBox.Items.Add("Model: " + row["Model"]);
            listCarBox.Items.Add("Year: " + row["Year"]);
        }

        private void RmvCar_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || !(comboBox1.SelectedItem is DataRowView row))
            {
                MessageBox.Show("Please select a valid Car ID.");
                return;
            }

            var confirmResult = MessageBox.Show(
                "Are you sure you want to remove this car?",
                "Confirmation",
                MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
                return;

            int carId = Convert.ToInt32(row["CarID"]);

            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "DELETE FROM Cars WHERE CarID = :id";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = carId;

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                            MessageBox.Show("Car removed successfully!");
                        else
                            MessageBox.Show("Car not found.");
                    }

                    listCarBox.Items.Clear();
                    comboBox1.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Are you sure you want to cancel?",
                "Confirmation",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                listCarBox.Items.Clear();
                comboBox1.SelectedIndex = -1;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void listCarBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
    }
}