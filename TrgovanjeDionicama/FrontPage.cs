using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TrgovanjeDionicama
{
    public partial class FrontPage : Form
    {

        readonly int userId;
        public FrontPage(int userId)
        {
            this.userId = userId; // postavlja identifikator korisnika na lokanu varijablu
            InitializeComponent();
            InitUI();
            Icon = Properties.Resources.icon;

            FormClosing += FrontPage_FormClosing;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            MinimizeBox = false;

        }

        private void FrontPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void FrontPageV2_Load(object sender, EventArgs e)
        {
            dateComboBox.SelectedIndex = 0;
            DateTime date = DateTime.UtcNow.Date;
            DateTime yesterday = date.AddDays(-1);
            var stocks = BrokerService.GetAllStocksByDate(date);
            foreach ( var stock in stocks )
            {
                Stock yesterdayStock = BrokerService.GetStockInfo(stock.Symbol, yesterday);
                decimal difference = stock.Price - yesterdayStock.Price;
                string[] row = {stock.Symbol, stock.Price.ToString(),  difference.ToString()};
                int rowIndex = stocksGridView.Rows.Add(row);
                DataGridViewCell cell = stocksGridView.Rows[rowIndex].Cells[2];

                cell.Style.ForeColor = difference > 0 ? Color.Green : (difference < 0 ? Color.Red : Color.Black);
            }
        }

        private void dateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.UtcNow.Date;
            DateTime date = DateTime.UtcNow.Date.AddDays(-1);
            var stocks = BrokerService.GetAllStocksByDate(today);
            stocksGridView.Rows.Clear();
            
            if (dateComboBox.SelectedIndex == 0)
            {
                date = today.AddDays(-1);
            }
            if (dateComboBox.SelectedIndex == 1)
            {
                date = today.AddDays(-2);
            }
            if (dateComboBox.SelectedIndex == 2)
            {
                date = today.AddDays(-7);
            }
            if (dateComboBox.SelectedIndex == 3)
            {
                date = today.AddDays(-14);
            }
            if (dateComboBox.SelectedIndex == 3)
            {
                date = today.AddMonths(-1);
            }
            if (dateComboBox.SelectedIndex == 4)
            {
                date = today.AddMonths(-2);
            }


            foreach (var stock in stocks)
            {
                Stock lastStock = BrokerService.GetStockInfo(stock.Symbol, date);
                decimal difference = stock.Price - lastStock.Price;
                string[] row = { stock.Symbol, stock.Price.ToString(), difference.ToString() };
                int rowIndex = stocksGridView.Rows.Add(row);
                DataGridViewCell cell = stocksGridView.Rows[rowIndex].Cells[2];

                cell.Style.ForeColor = difference > 0 ? Color.Green : (difference < 0 ? Color.Red : Color.Black);
            }
        }


        // Sluzi za dodavanje podataka u pie chart i u graf s podatcima o dionicama
        public void InitUI()
        {
            if (userId == 0)
            {
                WalletButton.Visible = false;
                PortfolioButton.Visible = false;
            }
            HistoryChart.Series.Remove(HistoryChart.Series["Series1"]);

            ////////////////////////////////////////////////////////////

            foreach (var stockName in WalletService.GetAvailableStocksWithValues().Keys)
            {
                HistoryChart.Series.Add(stockName); // za svaku dionicu radi novu Series instancu
                HistoryChart.Series[stockName].ChartType = SeriesChartType.Line;
                // Populate data points for each day
                for (int i = 0; i <= 30; i++)
                {
                    Dictionary<string, decimal> stockValues = Portfolio.GetAvailableStocksWithValuesForMonth(i - 30); // Pomocna funkcija iz forme Portfolio koja vraca rijecnik sa 

                    if (stockValues.ContainsKey(stockName))
                    {
                        HistoryChart.Series[stockName].Points.AddXY($"Day {i + 1}", stockValues[stockName]); // Dodaje tocku koje reprezentira vrijednost te dionicu u danom danu
                    }
                }
            }
        }

        private void WalletButton_Click(object sender, EventArgs e)
        {
            WalletForm wallet = new WalletForm(userId);
            Hide();
            wallet.ShowDialog();
            Close();
        }

        private void PortfolioButton_Click(object sender, EventArgs e)
        {
            Portfolio portfolio = new Portfolio(userId);
            Hide();
            portfolio.ShowDialog();
            Close();
        }
    }
}
