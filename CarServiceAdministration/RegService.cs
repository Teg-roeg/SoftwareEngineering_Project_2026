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
using System.Xml.Linq;

namespace CarServiceAdministration
{
    public partial class RegService : Form
    {
        public RegService()
        {
            InitializeComponent();
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Confirm Service Job Information?",
                                     "Confirmation",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

                using (OracleConnection con = new OracleConnection(Database.connectionString))
                {
                    try
                    {
                        con.Open();

                        string query = "INSERT INTO Services (SerID, ServiceName, Price) " +
                                       "VALUES (:id, :name, :price)";

                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {
                            cmd.Parameters.Add(":id", OracleDbType.Int32).Value = Convert.ToInt32(SerIDBox.Text);
                            cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = numSerBox.Text;
                            cmd.Parameters.Add(":price", OracleDbType.Varchar2).Value = txtPrice.Text;

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Service Job added successfully!");


                        SerIDBox.Clear();
                        numSerBox.Clear();
                        txtPrice.Clear();
                        SerIDBox.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message);
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void cusBox_Enter(object sender, EventArgs e)
        {

        }

        private void txtCarID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
