using CarServiceAdministration.DBConnect;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CarServiceAdministration
{
    public partial class MonthlyRevenueAnalysis : Form
    {
        public MonthlyRevenueAnalysis()
        {
            InitializeComponent();
        }

        private void MonthlyRevenueAnalysis_Load(object sender, EventArgs e)
        {
            LoadYears();
            yearCB.SelectedIndexChanged += yearCB_SelectedIndexChanged;

            if (yearCB.Items.Count > 0)
                yearCB.SelectedIndex = 0;
        }

        private void LoadYears()
        {
            string query = @"SELECT DISTINCT TO_CHAR(PaymentDate,'YYYY') 
                             FROM Payments 
                             ORDER BY TO_CHAR(PaymentDate,'YYYY')";

            DataSet ds = Database.ExecuteMultiRowQuery(query);

            yearCB.Items.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                yearCB.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void yearCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yearCB.SelectedItem != null)
            {
                LoadChartByYear(yearCB.SelectedItem.ToString());
            }
        }

        private void LoadChartByYear(string year)
        {
            string query = $@"SELECT 
                                SUM(AmntPaid), 
                                TO_CHAR(PaymentDate,'MM') 
                             FROM Payments 
                             WHERE TO_CHAR(PaymentDate,'YYYY') = '{year}'
                             GROUP BY TO_CHAR(PaymentDate,'MM') 
                             ORDER BY TO_CHAR(PaymentDate,'MM')";

            DataSet ds = Database.ExecuteMultiRowQuery(query);

            string[] months = { "JAN","FEB","MAR","APR","MAY","JUN",
                                "JUL","AUG","SEP","OCT","NOV","DEC" };

            decimal[] amounts = new decimal[12];

            for (int i = 0; i < 12; i++)
                amounts[i] = 0;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int monthIndex = Convert.ToInt32(ds.Tables[0].Rows[i][1]) - 1;

                if (ds.Tables[0].Rows[i][0] != DBNull.Value)
                {
                    amounts[monthIndex] = Convert.ToDecimal(ds.Tables[0].Rows[i][0]);
                }
            }

            chtData.Series.Clear();

            Series series = new Series();
            series.Name = "Revenue";
            series.ChartType = SeriesChartType.Column;
            series.Points.DataBindXY(months, amounts);
            series.IsValueShownAsLabel = true;

            chtData.Series.Add(series);

            chtData.ChartAreas[0].AxisX.Title = "Month";
            chtData.ChartAreas[0].AxisY.Title = "Revenue (€)";
            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            chtData.Titles.Clear();
            chtData.Titles.Add("Yearly Revenue for " + year);
            chtData.ChartAreas[0].AxisX.Interval = 1; 

            chtData.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            chtData.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }
    }
}