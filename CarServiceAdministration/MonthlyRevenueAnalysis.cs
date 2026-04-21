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
    public partial class MonthlyRevenueAnalysis : Form
    {
        public MonthlyRevenueAnalysis()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();   
            menu.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MonthlyRevenueAnalysis_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((monthCB.SelectedIndex == 0 || monthCB.SelectedIndex == 1 || monthCB.SelectedIndex == 2 || monthCB.SelectedIndex == 3) && (yearCB.SelectedIndex == 0))
            {
                listMonthly.Items.Clear();
                listMonthly.Items.Add("Total Monthly Revenue:"); 
                listMonthly.Items.Add("19,000.00€");
            }
            else if ((monthCB.SelectedIndex == 0 || monthCB.SelectedIndex == 1 || monthCB.SelectedIndex == 2 || monthCB.SelectedIndex == 3) && (yearCB.SelectedIndex == 1))
            {
                listMonthly.Items.Clear();
                listMonthly.Items.Add("Total Monthly Revenue:");
                listMonthly.Items.Add("23,500.40€");
            }
            else if ((monthCB.SelectedIndex == 0 || monthCB.SelectedIndex == 1 || monthCB.SelectedIndex == 2 || monthCB.SelectedIndex == 3) && (yearCB.SelectedIndex == 2))
            {
                listMonthly.Items.Clear();
                listMonthly.Items.Add("Total Monthly Revenue:");
                listMonthly.Items.Add("33,220.10€");
            }
        }
    }
}
