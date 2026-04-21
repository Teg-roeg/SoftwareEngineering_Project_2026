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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mechanicToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void regMechanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegMechanic f1 = new RegMechanic();
            f1.Show();
            this.Hide();
        }

        private void updateMechanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMechanic f2 = new UpdateMechanic();
            f2.Show();
            this.Hide();
        }

        private void removeMechanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveMechanic f3 = new RemoveMechanic();
            f3.Show();
            this.Hide();
        }

        private void regCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegCar f4 = new RegCar();
            f4.Show();
            this.Hide();
        }

        private void updateCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCar f5 = new UpdateCar();
            f5.Show();
            this.Hide();
        }

        private void removeCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCar f6 = new RemoveCar();
            f6.Show();
            this.Hide();
        }

        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void regServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegService f7 = new RegService();
            f7.Show();
            this.Hide();
        }

        private void updateServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateService f8 = new UpdateService();
            f8.Show();
            this.Hide();
        }

        private void removeServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveService f9 = new RemoveService();
            f9.Show();
            this.Hide();
        }

        private void regCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegCustomer f10 = new RegCustomer();
            f10.Show();
            this.Hide();
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCustomer f11 = new UpdateCustomer();
            f11.Show();
            this.Hide();
        }

        private void removeCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCustomer f12 = new RemoveCustomer();
            f12.Show();
            this.Hide();
        }

        private void scheduleBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleBooking f13 = new ScheduleBooking();
            f13.Show();
            this.Hide();
        }

        private void updateBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBooking f14 = new UpdateBooking();
            f14.Show();
            this.Hide();
        }

        private void cancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveBooking f15 = new RemoveBooking();
            f15.Show();
            this.Hide();
        }

        private void viewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBookings f16 = new ViewBookings();
            f16.Show();
            this.Hide();
        }

        private void generateInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateInvoice f17 = new GenerateInvoice();
            f17.Show();
            this.Hide();
        }

        private void recordPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordPayment f18 = new RecordPayment();
            f18.Show();
            this.Hide();
        }

        private void monthlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthlyRevenueAnalysis f19 = new MonthlyRevenueAnalysis();
            f19.Show();
            this.Hide();
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
