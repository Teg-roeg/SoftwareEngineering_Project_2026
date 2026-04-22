using CarServiceAdministration.DBConnect;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceAdministration
{
    public partial class ViewBookings : Form
    {
        public ViewBookings()
        {
            InitializeComponent();
        }

        private void ViewBookings_Load(object sender, EventArgs e)
        {
            LoadBookingIDs();
        }

        private void LoadBookingIDs()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    con.Open();
                    string query = "SELECT BookID FROM Bookings ORDER BY BookID";

                    using (OracleDataAdapter da = new OracleDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "BookID";
                        comboBox1.ValueMember = "BookID";
                        comboBox1.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message);
            }
        }

        private void comboBoxBookingIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;

            DataRowView row = (DataRowView)comboBox1.SelectedItem;

            int selectedBookID = Convert.ToInt32(row["BookID"]);

            LoadBookingDetails(selectedBookID);
        }
        private void LoadBookingDetails(int bookID)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    con.Open();
                    string query = @"
                SELECT b.BookID, c.Name AS CustomerName, ca.Brand, ca.Model, ca.Year, ca.RegNumber,
                       s.ServiceName, m.Name AS MechanicName, b.DateTime
                FROM Bookings b
                JOIN Customers c ON b.CusID = c.CusID
                JOIN Cars ca ON b.CarID = ca.CarID
                JOIN Services s ON b.SerID = s.SerID
                JOIN Mechanics m ON b.MechID = m.MechID
                WHERE b.BookID = :bookid";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":bookid", OracleDbType.Int32).Value = bookID;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            listBookBox.Items.Clear(); 

                            if (reader.Read())
                            {
                                listBookBox.Items.Add("Booking Id: " + reader["BookID"]);
                                listBookBox.Items.Add("Customer: " + reader["CustomerName"]);
                                listBookBox.Items.Add("Car: " + reader["Brand"] + " | " + reader["Model"] + " | " + reader["Year"]);
                                listBookBox.Items.Add("Registration: " + reader["RegNumber"]);
                                listBookBox.Items.Add("Service: " + reader["ServiceName"]);
                                listBookBox.Items.Add("Mechanic: " + reader["MechanicName"]);
                                listBookBox.Items.Add("Date: " + Convert.ToDateTime(reader["DateTime"]).ToString("dd/MM/yyyy HH:mm"));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading booking details: " + ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void listBookInfoBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void listBookBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}