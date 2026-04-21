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
    public partial class UpdateBooking : Form
    {
        public UpdateBooking()
        {
            InitializeComponent();
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Update Booking Details?",
                       "Confirmation",
                       MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("Details Updates Succsesfully");
                this.Controls.Clear();
                this.InitializeComponent();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mechCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
