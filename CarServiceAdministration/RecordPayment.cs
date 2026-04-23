using Oracle.ManagedDataAccess.Client;
using CarServiceAdministration.DBConnect;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceAdministration
{
    public partial class RecordPayment : Form
    {
        public RecordPayment()
        {
            InitializeComponent();
        }

        private void RecordPayment_Load(object sender, EventArgs e)
        {
            LoadInvoiceIDs();
        }

        private void LoadInvoiceIDs()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    con.Open();
                    string query = "SELECT InvID FROM Invoices ORDER BY InvID";

                    using (OracleDataAdapter da = new OracleDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        InvIDBox.DataSource = dt;
                        InvIDBox.DisplayMember = "InvID";
                        InvIDBox.ValueMember = "InvID";
                        InvIDBox.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading invoice IDs: " + ex.Message);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PayIDBox.Text))
            {
                MessageBox.Show("Enter Pay ID");
                return;
            }

            if (InvIDBox.SelectedItem == null)
            {
                MessageBox.Show("Select Invoice ID");
                return;
            }

         
            if (!decimal.TryParse(AmntPaid.Text.Trim(), out decimal amountPaid))
            {
                MessageBox.Show("Invalid amount");
                return;
            }

            int payID = Convert.ToInt32(PayIDBox.Text.Trim());
            int invID = Convert.ToInt32(((DataRowView)InvIDBox.SelectedItem)["InvID"]);

            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                con.Open();
                string query = @"
            INSERT INTO Payments (PayID, InvID, AmntPaid, PaymentDate)
            VALUES (:payid, :invid, :amt, :paydate)";

                using (OracleCommand cmd = new OracleCommand(query, con))
                {
                    cmd.Parameters.Add(":payid", OracleDbType.Int32).Value = payID;
                    cmd.Parameters.Add(":invid", OracleDbType.Int32).Value = invID;
                    cmd.Parameters.Add(":amt", OracleDbType.Decimal).Value = amountPaid;
                    cmd.Parameters.Add(":paydate", OracleDbType.TimeStamp).Value = paymentDatePicker.Value;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment recorded successfully!");
                }
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