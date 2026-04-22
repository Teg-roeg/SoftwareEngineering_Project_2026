using CarServiceAdministration.DBConnect;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceAdministration
{
    public partial class UpdateBooking : Form
    {
        private DataRow selectedCar; 
        private DataRow selectedBooking; 

        public UpdateBooking()
        {
            InitializeComponent();
        }

        private void UpdateBooking_Load(object sender, EventArgs e)
        {
            LoadAllCars();
            LoadMechanics();
            LoadServices();
            LoadBookingIDs();
        }


        private void LoadAllCars()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    con.Open();
                    string query = "SELECT CarID, CusID, RegNumber, Brand, Model, Year FROM Cars";

                    using (OracleDataAdapter da = new OracleDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        grdCars.DataSource = dt;
                        grdCars.Columns["CarID"].HeaderText = "Car ID";
                        grdCars.Columns["CusID"].HeaderText = "Customer ID";
                        grdCars.Columns["RegNumber"].HeaderText = "Registration";
                        grdCars.Columns["Brand"].HeaderText = "Brand";
                        grdCars.Columns["Model"].HeaderText = "Model";
                        grdCars.Columns["Year"].HeaderText = "Year";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cars: " + ex.Message);
            }
        }

        private void LoadMechanics()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    con.Open();
                    string query = "SELECT MechID FROM Mechanics";
                    using (OracleDataAdapter da = new OracleDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        mechCB.DataSource = dt;
                        mechCB.DisplayMember = "MechID";
                        mechCB.ValueMember = "MechID";
                        mechCB.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading mechanics: " + ex.Message);
            }
        }

        private void LoadServices()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    con.Open();
                    string query = "SELECT SerID FROM Services";
                    using (OracleDataAdapter da = new OracleDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        serviceCB.DataSource = dt;
                        serviceCB.DisplayMember = "SerID";
                        serviceCB.ValueMember = "SerID";
                        serviceCB.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading services: " + ex.Message);
            }
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
                MessageBox.Show("Error loading booking IDs: " + ex.Message);
            }
        }

        private void bookIDBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookIDBox.SelectedItem == null)
                return;

            selectedBooking = ((DataRowView)bookIDBox.SelectedItem).Row;
            int bookID = Convert.ToInt32(selectedBooking["BookID"]);

            try
            {
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    con.Open();
                    string query = @"
                        SELECT CarID, CusID, SerID, MechID, DateTime
                        FROM Bookings
                        WHERE BookID = :bookid";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":bookid", OracleDbType.Int32).Value = bookID;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                bookingDatePicker.Value = Convert.ToDateTime(reader["DateTime"]);

                                serviceCB.SelectedValue = reader["SerID"];
                                mechCB.SelectedValue = reader["MechID"];

                                int carID = Convert.ToInt32(reader["CarID"]);
                                foreach (DataGridViewRow row in grdCars.Rows)
                                {
                                    if (Convert.ToInt32(row.Cells["CarID"].Value) == carID)
                                    {
                                        row.Selected = true;
                                        selectedCar = ((DataRowView)row.DataBoundItem).Row;
                                        break;
                                    }
                                }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    con.Open();
                    string query;
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;

                    if (string.IsNullOrWhiteSpace(txtSearch.Text))
                    {
                        query = "SELECT CarID, CusID, RegNumber, Brand, Model, Year FROM Cars";
                    }
                    else
                    {
                        query = "SELECT CarID, CusID, RegNumber, Brand, Model, Year FROM Cars WHERE CusID = :id";
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = Convert.ToInt32(txtSearch.Text.Trim());
                    }

                    cmd.CommandText = query;


                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No customer found.");
                            return;
                        }

                        grdCars.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching cars: " + ex.Message);
            }
        }

        private void grdCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            selectedCar = ((DataRowView)grdCars.Rows[e.RowIndex].DataBoundItem).Row;
        }


        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            if (selectedBooking == null)
            {
                MessageBox.Show("Please select a booking first.");
                return;
            }

            if (selectedCar == null)
            {
                MessageBox.Show("Please select a car.");
                return;
            }

            var confirm = MessageBox.Show("Update booking details?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    con.Open();
                    string query = @"
                        UPDATE Bookings
                        SET CarID = :carid, SerID = :serid, MechID = :mechid, DateTime = :datetime
                        WHERE BookID = :bookid";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":carid", OracleDbType.Int32).Value = Convert.ToInt32(selectedCar["CarID"]);
                        cmd.Parameters.Add(":serid", OracleDbType.Int32).Value = Convert.ToInt32(serviceCB.SelectedValue);
                        cmd.Parameters.Add(":mechid", OracleDbType.Int32).Value = Convert.ToInt32(mechCB.SelectedValue);
                        cmd.Parameters.Add(":datetime", OracleDbType.TimeStamp).Value = bookingDatePicker.Value;
                        cmd.Parameters.Add(":bookid", OracleDbType.Int32).Value = Convert.ToInt32(selectedBooking["BookID"]);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                            MessageBox.Show("Booking updated successfully!");
                        else
                            MessageBox.Show("Booking update failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }
    }
}