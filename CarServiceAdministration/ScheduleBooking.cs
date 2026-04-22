using CarServiceAdministration.DBConnect;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceAdministration
{
    public partial class ScheduleBooking : Form
    {
        private DataRow selectedCar;
        public ScheduleBooking()
        {
            InitializeComponent();
        }

        private void ScheduleBooking_Load(object sender, EventArgs e)
        {
            LoadAllCars();
            LoadServices();
            LoadMechanics();
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

        private void LoadServices()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    con.Open();
                    string query = "SELECT SerID FROM Services"; // only ID

                    using (OracleDataAdapter da = new OracleDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No services found.");
                            return;
                        }

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

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No mechanics found.");
                            return;
                        }

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
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        private void grdCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedCar = ((DataRowView)grdCars.Rows[e.RowIndex].DataBoundItem).Row;

        }

        private void btnScheduleBooking_Click(object sender, EventArgs e)
        {
            if (selectedCar == null)
            {
                MessageBox.Show("Please select a car first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBookingID.Text))
            {
                MessageBox.Show("Please enter a Booking ID.");
                return;
            }

            if (serviceCB.SelectedValue == null)
            {
                MessageBox.Show("Please select a Service ID.");
                return;
            }

            if (mechCB.SelectedValue == null)
            {
                MessageBox.Show("Please select a Mechanic ID.");
                return;
            }

            var confirmResult = MessageBox.Show(
                "Schedule booking for selected car?",
                "Confirmation",
                MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes) return;

            try
            {
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    con.Open();

                    string query = "INSERT INTO Bookings (BookID, CusID, CarID, SerID, MechID, DateTime) " +
                                   "VALUES (:bookid, :cusid, :carid, :serid, :mechid, :datetime)";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":bookid", OracleDbType.Int32).Value = Convert.ToInt32(txtBookingID.Text.Trim());
                        cmd.Parameters.Add(":cusid", OracleDbType.Int32).Value = Convert.ToInt32(selectedCar["CusID"]);
                        cmd.Parameters.Add(":carid", OracleDbType.Int32).Value = Convert.ToInt32(selectedCar["CarID"]);
                        cmd.Parameters.Add(":serid", OracleDbType.Int32).Value = Convert.ToInt32(serviceCB.SelectedValue);
                        cmd.Parameters.Add(":mechid", OracleDbType.Int32).Value = Convert.ToInt32(mechCB.SelectedValue);
                        cmd.Parameters.Add(":datetime", OracleDbType.TimeStamp).Value = bookingDatePicker.Value;

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            MessageBox.Show("Booking scheduled successfully!");
                        else
                            MessageBox.Show("Booking could not be added.");
                    }
                }


                txtBookingID.Clear();
                selectedCar = null;
                bookingDatePicker.Value = DateTime.Now;
                serviceCB.SelectedIndex = -1;
                mechCB.SelectedIndex = -1;
                LoadAllCars();
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

        private void grdCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}