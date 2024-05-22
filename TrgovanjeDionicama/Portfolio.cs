using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TrgovanjeDionicama
{
    public partial class Portfolio : Form
    {
        public int userId;
        public Portfolio(int user)
        {
            this.userId = user;
            InitializeComponent();
            InitUI();

            Icon = Properties.Resources.icon;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            MinimizeBox = false;

            //omogucen tablicni prikaz podataka o korisnikovim dionicama
            var stocks = WalletService.GetAvailableStocksWithValues();

            List<StockOwnershipVM> stockOwnerships = WalletService.GetOwnedStocks(userId)
                .Select(x => new StockOwnershipVM() 
                {
                    StockSymbol = x.StockSymbol,
                    Quantity = x.Quantity,
                    Worth = stocks[x.StockSymbol] * x.Quantity
                }).ToList();

            if (!stockOwnerships.Any()) 
            {
                dataGridView1.Visible = false;
                MessageBox.Show("You do not own any stocks.");
            }
            
            dataGridView1.DataSource = stockOwnerships;

            dataGridView1.ClearSelection();
        }

        public static Dictionary<string, decimal> GetAvailableStocksWithValuesForMonth(int i)
        {
            using (var context = new StockExchangeDbContext())
            {
                var date = DateTime.UtcNow.Date;
                var beforedate = date.AddDays(i);
                return context.Stocks.Where(stock => stock.Date == beforedate).ToDictionary(stock => stock.Symbol, stock => stock.Price);
            }
        }

        public decimal CalculatePortfolioValue(int i)
        {
            decimal value = WalletService.GetWallet(userId).Amount;

            List<Transaction> transactions = WalletService.GetTransactions(userId);

            Dictionary<string, decimal> stockPrices = GetAvailableStocksWithValuesForMonth(-i);

            foreach (var transaction in transactions)
            {
                if (transaction.DateTimeUTC >= DateTime.UtcNow.Date.AddDays(-i) && stockPrices.ContainsKey(transaction.StockSymbol))
                {


                    if (transaction.TransactionType == TransactionTypeEnum.Buy)
                    {
                        value += transaction.Amount * transaction.StockAmount;
                    }

                    if (transaction.TransactionType == TransactionTypeEnum.Sell)
                    {
                        value -= transaction.Amount * transaction.StockAmount;
                    }
                }
            }

            return value;
        }

        public void InitUI()
        {
            var value = WalletService.CalculatePortfolioWorth(userId);
            textBoxValue.Text = $"Portfolio value: {value}";
            textBoxYesterdayValue.Text = $"Change from yesterday: {WalletService.CalculatePortfolioWorthYesterday(userId)-value}";
            List<StockOwnership> stockOwnerships = WalletService.GetOwnedStocks(userId);
            var stocks = WalletService.GetAvailableStocksWithValues();
            foreach (var instance in stockOwnerships)
            {
                if (instance.Quantity > 0 && stocks.ContainsKey(instance.StockSymbol))
                    PieChart.Series["StocksDistribution"].Points.AddXY(instance.StockSymbol, instance.Quantity * stocks[instance.StockSymbol]);
            }

            ///////////////////////////////////////////////////////////
            List<Transaction> transactions = WalletService.GetTransactions(userId);

            for (int i = 29; i >= 0; i--)
            {
                DateTime currentDate = DateTime.UtcNow.Date.AddDays(-i);
                decimal portfolioValue = CalculatePortfolioValue(-i);
                HistoryChart.Series["HistorySeries"].BorderWidth = 2;
                HistoryChart.Series["HistorySeries"].Points.AddXY(currentDate, portfolioValue);
            }
        }

        private void WalletButton_Click(object sender, EventArgs e)
        {
            WalletForm wallet = new WalletForm(userId);
            Hide();
            wallet.ShowDialog();
            Close();
        }

        private void FrontPageButton_Click(object sender, EventArgs e)
        {
            FrontPage page = new FrontPage(userId);
            Hide();
            page.ShowDialog();
            Close();
        }
    }

    /// <summary>
    /// VM class to display grid with owned stocks
    /// </summary>
    public class StockOwnershipVM 
    {
        public string StockSymbol { get; set; }
        public decimal Quantity { get; set; }
        public decimal Worth { get; set; }
    }


}
