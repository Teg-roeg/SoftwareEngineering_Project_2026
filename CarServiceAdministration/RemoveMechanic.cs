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
    public partial class RemoveMechanic : Form
    {
        public RemoveMechanic()
        {
            InitializeComponent();
        }

        private void RemoveMechanic_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listMechBox.Items.Clear();

                listMechBox.Items.Add("Mechanic Id: 1");
                listMechBox.Items.Add("Mechanic Name: Alexander Kravintski");
                listMechBox.Items.Add("Phone Number: 0876712698");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listMechBox.Items.Clear();

                listMechBox.Items.Add("Mechanic Id: 2");
                listMechBox.Items.Add("Mechanic Name: John Doe");
                listMechBox.Items.Add("Phone Number: 0876912678");
            }
        }

        private void AddMechanic_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to remove data?",
                                     "Confirmation",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("Mechanic Removed Successfully");
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                listMechBox.Items.Clear();
                comboBox1.Focus();
            }
            else
            {
                return;
            }
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

        private void listMechBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
