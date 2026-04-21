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
    public partial class ScheduleBooking : Form
    {
        public ScheduleBooking()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cusCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cusCB.SelectedIndex == 0)  
            {
                listBox1.Items.Clear();  


                listBox1.Items.Add("Customer: Lisa Robins");


            }
            else if (cusCB.SelectedIndex == 1)
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("Customer: Johnathan Banks");

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void serviceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serviceCB.SelectedIndex == 0)   
            {
                listBox3.Items.Clear();  


                listBox3.Items.Add("Parts Change");


            }
            else if (serviceCB.SelectedIndex == 1)
            {
                listBox3.Items.Clear();

                listBox3.Items.Add("Oil Change");

            }
        }

        private void mechCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mechCB.SelectedIndex == 0)   
            {
                listBox4.Items.Clear();  


                listBox4.Items.Add("Alexander Kravintski");


            }
            else if (mechCB.SelectedIndex == 1)
            {
                listBox4.Items.Clear();

                listBox4.Items.Add("John Doe");

            }
        }

        private void carCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carCB.SelectedIndex == 0)  
            {
                listBox2.Items.Clear();  


                listBox2.Items.Add("Car: Chevrolett | Camaro | 2010 ");


            }
            else if (cusCB.SelectedIndex == 1)
            {
                listBox2.Items.Clear();

                listBox2.Items.Add("Car: Toyota | Celica | 2002");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Confirm Booking Information?",
                                     "Confirmation",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) ;
        
                
                
        }
        

        private void bookCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
