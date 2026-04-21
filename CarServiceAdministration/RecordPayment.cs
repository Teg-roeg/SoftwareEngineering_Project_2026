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
    public partial class RecordPayment : Form
    {
        public RecordPayment()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bookCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookCB.SelectedIndex == 0)  
            {
                listInvc.Items.Clear();  

                listInvc.Items.Add("Invoice ID: 1");
                listInvc.Items.Add("Amount to Pay: 350.00");

            }
            else if (bookCB.SelectedIndex == 1)
            {
                listInvc.Items.Clear();  

                listInvc.Items.Add("Invoice ID: 2");
                listInvc.Items.Add("Amount to Pay: 120.00");

            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void listInvc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to change Payment Record Status?",
                                     "Confirmation",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Controls.Clear();
                this.InitializeComponent();
                bookCB.Focus();
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

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void regServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
