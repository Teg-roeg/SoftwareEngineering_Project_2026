using Oracle.ManagedDataAccess.Client;
using CarServiceAdministration.DBConnect;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceAdministration
{
    public partial class GenerateInvoice : Form
    {
        public GenerateInvoice()
        {
            InitializeComponent();
        }

        private void GenerateInvoice_Load(object sender, EventArgs e)
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
                        bookIDBox.DataSource = dt;
                        bookIDBox.DisplayMember = "BookID";
                        bookIDBox.ValueMember = "BookID";
                        bookIDBox.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message);
            }
        }

 
        private void bookIDBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookIDBox.SelectedItem == null) return;

            DataRowView row = (DataRowView)bookIDBox.SelectedItem;
            int bookID = Convert.ToInt32(row["BookID"]);

            try
            {
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    con.Open();
                    string query = @"
                        SELECT b.BookID, c.Name AS CustomerName, ca.Brand, ca.Model, ca.Year, ca.RegNumber,
                               s.ServiceName, s.Price, m.Name AS MechanicName,
                               b.DateTime
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
                            invListBox.Items.Clear();

                            if (reader.Read())
                            {
                                invListBox.Items.Add("Booking ID: " + reader["BookID"]);
                                invListBox.Items.Add("Customer: " + reader["CustomerName"]);
                                invListBox.Items.Add("Car: " + reader["Brand"] + " | " + reader["Model"] + " | " + reader["Year"]);
                                invListBox.Items.Add("Registration: " + reader["RegNumber"]);
                                invListBox.Items.Add("Service: " + reader["ServiceName"]);
                                invListBox.Items.Add("Mechanic: " + reader["MechanicName"]);
                                invListBox.Items.Add("Booking Date: " + Convert.ToDateTime(reader["DateTime"]).ToString("dd/MM/yyyy HH:mm"));
                                invListBox.Items.Add("Price: $" + Convert.ToDecimal(reader["Price"]).ToString("0.00"));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading booking info: " + ex.Message);
            }
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            if (bookIDBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a booking.");
                return;
            }

            DataRowView row = (DataRowView)bookIDBox.SelectedItem;
            int bookID = Convert.ToInt32(row["BookID"]);

            decimal price = 0;
            if (invListBox.Items.Count > 0)
            {
              
                string priceText = invListBox.Items[invListBox.Items.Count - 1].ToString().Replace("Price: $", "");
                decimal.TryParse(priceText, out price);
            }

            try
            {
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    con.Open();

                  
                    int newInvID = 1;
                    using (OracleCommand cmdMax = new OracleCommand("SELECT NVL(MAX(InvID),0)+1 FROM Invoices", con)) // unique logic for invoice I, copilot helped
                    {
                        newInvID = Convert.ToInt32(cmdMax.ExecuteScalar());
                    }

                    string insertQuery = "INSERT INTO Invoices (InvID, BookID, Price) VALUES (:invid, :bookid, :price)";
                    using (OracleCommand cmd = new OracleCommand(insertQuery, con))
                    {
                        cmd.Parameters.Add(":invid", OracleDbType.Int32).Value = newInvID;
                        cmd.Parameters.Add(":bookid", OracleDbType.Int32).Value = bookID;
                        cmd.Parameters.Add(":price", OracleDbType.Decimal).Value = price;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Invoice generated successfully! Invoice ID: {newInvID}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating invoice: " + ex.Message);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e) { } // I can't remove this as it will corrupt the form, and I don't know where to find this properties
        private void invListBox_SelectedIndexChanged(object sender, EventArgs e) { } //

        private void CusPhoneNum_Click(object sender, EventArgs e) { } //

        private void invBookID_Click(object sender, EventArgs e) { } //

        private void CusID_Click(object sender, EventArgs e) { } //

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }
    }
}