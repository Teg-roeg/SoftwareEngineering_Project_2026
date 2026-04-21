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
    public partial class RemoveCar : Form
    {
        public RemoveCar()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listCarBox.Items.Clear();

                listCarBox.Items.Add("Car Id: 1");
                listCarBox.Items.Add("Customer: Jonathan Banks");
                listCarBox.Items.Add("Registration Number: 08C2542");
                listCarBox.Items.Add("Brand: Toyota");
                listCarBox.Items.Add("Model: Celica");
                listCarBox.Items.Add("Year: 2002");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listCarBox.Items.Clear();

                listCarBox.Items.Add("Car Id: 2");
                listCarBox.Items.Add("Customer: Lisa Robins");
                listCarBox.Items.Add("Registration Number: 08E6769");
                listCarBox.Items.Add("Brand: Chevrolet");
                listCarBox.Items.Add("Model: Camaro");
                listCarBox.Items.Add("Year: 2010");
            }
        }

        private void RmvCar_Click(object sender, EventArgs e)
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }
    }
}
