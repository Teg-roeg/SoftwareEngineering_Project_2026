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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarServiceAdministration
{
    public partial class RemoveService : Form
    {
        public RemoveService()
        {
            InitializeComponent();
        }
        private void RemoveService_Load(object sender, EventArgs e)
        {
            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT SerID, ServiceName, Price FROM Services";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());

                        SerIDBox.DataSource = dt;
                        SerIDBox.DisplayMember = "SerID";
                        SerIDBox.ValueMember = "SerID";
                        SerIDBox.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading services: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show( "Are you sure you want to cancel?","Confirmation",MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
                return;

            SerIDBox.SelectedIndex = -1;
            listServBox.Items.Clear();
        }

        private void SerIDBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SerIDBox.SelectedItem == null || !(SerIDBox.SelectedItem is DataRowView row))
                return;

            listServBox.Items.Clear();

            listServBox.Items.Add("Service Id: " + row["SerID"]);
            listServBox.Items.Add("Service Name: " + row["ServiceName"]);
            listServBox.Items.Add("Price: " + row["Price"]);
        }

        private void RmvService_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Are you sure you want to remove data?",
                "Confirmation",
                MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
                return;

            if (SerIDBox.SelectedItem == null || !(SerIDBox.SelectedItem is DataRowView row))
            {
                MessageBox.Show("Please select a valid Service ID.");
                return;
            }

            int cusId = Convert.ToInt32(row["SerID"]);

            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                try
                {
                    con.Open();

                    string query = "DELETE FROM Services WHERE SerID = :id";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = cusId;

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                            MessageBox.Show("Service Removed Successfully");
                        else
                            MessageBox.Show("Service not found.");
                    }

                    listServBox.Items.Clear();
                    SerIDBox.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void listServBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
