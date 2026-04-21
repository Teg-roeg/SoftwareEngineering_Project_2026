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
    public partial class ViewBookings : Form
    {
        public ViewBookings()
        {
            InitializeComponent();
            listBookBox.Items.Add("1");
            listBookBox.Items.Add("2");
            listBookBox.Items.Add("3");
        }

        private void listBookBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewBookings_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void listBookBox_Click(object sender, EventArgs e)
        {
         
                    
            if (listBookBox.SelectedIndex == -1)
             return;

            

            switch (listBookBox.SelectedIndex)
            {
                case 0:
                    listBookInfoBox.Items.Clear();
                    listBookInfoBox.Items.Add("Pay ID: 1");
                    listBookInfoBox.Items.Add("Book ID: 1");
                    listBookInfoBox.Items.Add("Customer: Lisa Robins");
                    listBookInfoBox.Items.Add("Car: Chevrolett | Camaro | 2010 ");
                    listBookInfoBox.Items.Add("Service: Parts Change");
                    listBookInfoBox.Items.Add("Mechanic: Alexander Kravintski");
                    listBookInfoBox.Items.Add("Date: 12/7/2025 14:30");
                    listStatus.Items.Clear();
                    listStatus.Items.Add("Unpaid");
                    break;

                case 1:
                    listBookInfoBox.Items.Clear();
                    listBookInfoBox.Items.Add("Pay ID: 2");
                    listBookInfoBox.Items.Add("Book ID: 2");
                    listBookInfoBox.Items.Add("Customer: Johnathan Banks");
                    listBookInfoBox.Items.Add("Car: Toyota | Celica | 2002");
                    listBookInfoBox.Items.Add("Service: Oil Change");
                    listBookInfoBox.Items.Add("Mechanic: John Doe");
                    listBookInfoBox.Items.Add("Date: 7/8/2025 16:00");
                    listStatus.Items.Clear();
                    listStatus.Items.Add("Unpaid");
                    break;

                case 2:
                    listBookInfoBox.Items.Clear();
                    listBookInfoBox.Items.Add("Pay ID: 3");
                    listBookInfoBox.Items.Add("Book ID: 3");
                    listBookInfoBox.Items.Add("Customer: Joseph Connely");
                    listBookInfoBox.Items.Add("Car: Toyota | Corolla | 2008");
                    listBookInfoBox.Items.Add("Service: Oil Change");
                    listBookInfoBox.Items.Add("Mechanic: John Doe");
                    listBookInfoBox.Items.Add("Date: 6/1/2025 13:00");
                    listStatus.Items.Clear();
                    listStatus.Items.Add("Paid");
                    break;

            }
        }

        private void listBookInfoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBookBox_Leave(object sender, EventArgs e)
        {

        }

        private void listStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
