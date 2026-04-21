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
    public partial class GenerateInvoice : Form
    {
        OracleConnection conn = new OracleConnection(Database.connectionString);
        public GenerateInvoice()
        {
            InitializeComponent();
            
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

        private void CusID_Click(object sender, EventArgs e)
        {

        }

        private void CusPhoneNum_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)   
            {
                invListBox.Items.Clear(); 

                invListBox.Items.Add("Book ID: 1");
                invListBox.Items.Add("Customer: Lisa Robins");
                invListBox.Items.Add("Car: Chevrolett | Camaro | 2010 ");
                invListBox.Items.Add("Service: Parts Change");
                invListBox.Items.Add("Mechanic: Alexander Kravintski");
                invListBox.Items.Add("Date: 12/7/2025 14:30");
                invListBox.Items.Add("Status: Queue for Payment");

                txtPrice.Text = "350.00";
                txtPrice.ForeColor = Color.Black;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                invListBox.Items.Clear();  

                invListBox.Items.Add("Book ID: 2");
                invListBox.Items.Add("Customer: Johnathan Banks");
                invListBox.Items.Add("Car: Toyota | Celica | 2002");
                invListBox.Items.Add("Service: Oil Change");
                invListBox.Items.Add("Mechanic: John Doe");
                invListBox.Items.Add("Date: 7/8/2025 16:00");
                invListBox.Items.Add("Status: Queue for Payment");

                txtPrice.Text = "120.00";
                txtPrice.ForeColor = Color.Black;
            }
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text == "0.00")
            {
                txtPrice.Clear();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrice.ForeColor = Color.Black;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtPrice.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                txtPrice.ForeColor = Color.Gray;
                txtPrice.Text = "0.00";
                return;
            }

            if (decimal.TryParse(txtPrice.Text, out decimal value))
            {
                txtPrice.ForeColor = Color.Black;
                txtPrice.Text = value.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Invalid price format!");
                txtPrice.Text = "0.00";
                txtPrice.ForeColor = Color.Gray;
            }
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to generate this invoice?",
                                     "Confirmation",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Controls.Clear();
                this.InitializeComponent();
                invBox.Focus();
            }
            else
            {
                return;
            }
        }

        private void invBookID_Click(object sender, EventArgs e)
        {

        }
    }
}
