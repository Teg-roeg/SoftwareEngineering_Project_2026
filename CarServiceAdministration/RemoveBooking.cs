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
    public partial class RemoveBooking : Form
    {
        public RemoveBooking()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listBookBox.Items.Clear();

                listBookBox.Items.Add("Book Id: 1");
                listBookBox.Items.Add("Customer Name: Lisa Robins");
                listBookBox.Items.Add("Car: Chevrolett | Camaro | 2010");
                listBookBox.Items.Add("Service: Parts Change");
                listBookBox.Items.Add("Mechanic Name: Alexander Kravintski");
                listBookBox.Items.Add("Date: 12/7/2025 14:30");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBookBox.Items.Clear();

                listBookBox.Items.Add("Book Id: 2");
                listBookBox.Items.Add("Customer Name: Jonathan Banks");
                listBookBox.Items.Add("Car: Toyota | Celica | 2002");
                listBookBox.Items.Add("Service: Oil Change");
                listBookBox.Items.Add("Mechanic Name: John Doe");
                listBookBox.Items.Add("Date: 14/6/2025 16:00");
            }
        }

        private void listCusBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to cancel?",
             "Confirmation",
             MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Controls.Clear();
                this.InitializeComponent();
                comboBox1.Focus();
            }
            else
            {
                return;
            }
        }

        private void RmvBooking_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to remove data?",
                         "Confirmation",
                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("Booking Removed Successfully");
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                listBookBox.Items.Clear();
                comboBox1.Focus();
            }
            else
            {
                return;
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
