using Oracle.ManagedDataAccess.Client;
using CarServiceAdministration.DBConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceAdministration
{
    public partial class RegMechanic : Form
    {
        public RegMechanic()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void AddMechanic_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Confirm Mechanic's Information?",
                             "Confirmation",
                             MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    con.Open();

                    string query = "INSERT INTO Mechanics (MechID, Name, PhoneNum) " + 
                        "VALUES (:id, :name, :phone)";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value =
                            Convert.ToInt32(txtCusID.Text);

                        cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value =
                            txtName.Text.Trim();

                        cmd.Parameters.Add(":phone", OracleDbType.Varchar2).Value =
                            txtPhone.Text.Trim();

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Mechanic added successfully!");

                txtCusID.Clear();
                txtName.Clear();
                txtPhone.Clear();
                txtCusID.Focus();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }
    }
}
