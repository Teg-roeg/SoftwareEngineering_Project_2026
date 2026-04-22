using CarServiceAdministration.DBConnect;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceAdministration
{
    public partial class RemoveBooking : Form
    {
        public RemoveBooking()
        {
            InitializeComponent();
        }

        private void RemoveBooking_Load(object sender, EventArgs e)
        {
            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT BookID, CusID, CarID, SerID, MechID, DateTime FROM Bookings";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());

                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "BookID";
                        comboBox1.ValueMember = "BookID";
                        comboBox1.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading bookings: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || !(comboBox1.SelectedItem is DataRowView row))
                return;

            listBookBox.Items.Clear();

            listBookBox.Items.Add("Booking Id: " + row["BookID"]);
            listBookBox.Items.Add("Customer Id: " + row["CusID"]);
            listBookBox.Items.Add("Car Id: " + row["CarID"]);
            listBookBox.Items.Add("Service Id: " + row["SerID"]);
            listBookBox.Items.Add("Mechanic Id: " + row["MechID"]);
            listBookBox.Items.Add("Date: " + Convert.ToDateTime(row["DateTime"]).ToString("dd/MM/yyyy HH:mm"));
        }

        private void RmvBooking_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || !(comboBox1.SelectedItem is DataRowView row))
            {
                MessageBox.Show("Please select a valid Booking ID.");
                return;
            }

            var confirmResult = MessageBox.Show(
                "Are you sure you want to remove this booking?",
                "Confirmation",
                MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
                return;

            int bookId = Convert.ToInt32(row["BookID"]);

            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "DELETE FROM Bookings WHERE BookID = :id";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = bookId;

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                            MessageBox.Show("Booking Removed Successfully");
                        else
                            MessageBox.Show("Booking not found.");
                    }

                    listBookBox.Items.Clear();
                    comboBox1.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Are you sure you want to cancel?",
                "Confirmation",
                MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
                return;

            comboBox1.SelectedIndex = -1;
            listBookBox.Items.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void listCusBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}