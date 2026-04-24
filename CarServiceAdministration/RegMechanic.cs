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
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarServiceAdministration
{
    public partial class RegMechanic : Form
    {
        public RegMechanic()
        {
            InitializeComponent(); // start the form
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1(); // go back to the menu
            menu.Show();
            this.Close();
        }

        private void AddMechanic_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim(); // .Text.Trim() converts text from textbox with spaces/tabs to a data for SQL query without any leading and traveling tabs or spaces
            string phone = txtPhone.Text.Trim();
            string idText = txtCusID.Text.Trim();

            if (!int.TryParse(idText, out int mechId))
            {
                MessageBox.Show("Mechanic ID must be a number."); // if Mechanid ID is a anything else except the digit
                txtCusID.Focus();
                return;
            }

            if (name.Any(char.IsDigit))
            {
                MessageBox.Show("Name cannot contain numbers."); // when Name contains digits
                txtName.Focus();
                return;
            }

            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must contain digits only."); // if phone contains anything else than digit
                txtPhone.Focus();
                return;
            }

            if (phone.Length < 10 || phone.Length > 10)
            {
                MessageBox.Show("Phone number cannot be more or less than 10 digits."); // if the phone number longer than 10 digits
                txtPhone.Focus();
                return;
            }

            var confirmResult = MessageBox.Show("Confirm Mechanic's Information?", "Confirmation", MessageBoxButtons.YesNo); // variable created to validate user's answer when inserted data to the boxes

            if (confirmResult != DialogResult.Yes) // If user hits yes then next code proceed to execute and add data to DataBase
                return;

            try
            {
                using (OracleConnection con = new OracleConnection(Database.connectionString)) // Connecting to DataBase each time this executes
                {
                    con.Open(); // Open connection between application and oracle

                    string query = "INSERT INTO Mechanics (MechID, Name, PhoneNum) " + "VALUES (:id, :name, :phone)"; // executes SQL query to add information

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = mechId; // converts character inserted into the box(integer) and converts it to data for SQL query to be inserted

                        cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = name; 

                        cmd.Parameters.Add(":phone", OracleDbType.Varchar2).Value = phone;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Mechanic added successfully!"); // Message box appear on screen with following text

                txtCusID.Clear(); // Clears the textboxes after execution and adding data to DataBase
                txtName.Clear();
                txtPhone.Clear();
                txtCusID.Focus(); // Focusing on first element of UI when clears all the textboxes
            }
            catch (OracleException ex) // Exceptions error
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
