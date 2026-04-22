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
    public partial class RemoveService : Form
    {
        public RemoveService()
        {
            InitializeComponent();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listServBox.Items.Clear();

                listServBox.Items.Add("Service Id: 1");
                listServBox.Items.Add("Service Name: Oil Change");
                listServBox.Items.Add("Price: 120.00€");
            }
        }

        private void RmvService_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to remove data?",
                                     "Confirmation",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("Service Removed Successfully");
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                listServBox.Items.Clear();
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

        private void listServBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
