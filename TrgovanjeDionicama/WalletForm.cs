using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TrgovanjeDionicama
{
    public partial class WalletForm : Form
    {
        readonly int userId; 
        public WalletForm(int userId)
        {
            this.userId = userId;
            if (WalletService.GetWallet(userId) == null) 
            {
                MessageBox.Show("Error! Please contact our customer support");
                return; //TO DO
            }
            InitializeComponent();

            Icon = Properties.Resources.icon;
            dataGridTransactions.CellFormatting += DataGridTransactions_CellFormatting; //za uređivanje brojeva transakcija i promjene vrijednosti dionica
            FormBorderStyle = FormBorderStyle.FixedSingle;//ne želimo omogućiti korisnicima promjenu veličine prozora
            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void DataGridTransactions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int columnIndex = 0;

            if (e.ColumnIndex == columnIndex && e.RowIndex >= 0)
            {
                e.Value = TransformValue(e.Value.ToString());
                e.FormattingApplied = true;
            }

            //promjena boje ovisno o zaradi ili gubitku
            if (e.ColumnIndex == dataGridTransactions.Columns["Difference"].Index && e.Value != null)
            {
                decimal value = decimal.Parse(e.Value.ToString());
                if(value < 0)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else if (value > 0)
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                //
                else if(e.Value.ToString() == "0")
                {
                    e.Value = "-";
                }
            }
        }

        private string TransformValue(string originalValue)
        {

            String stringValue = int.Parse(originalValue).ToString("X8");
            String transformed = $"TXN-{stringValue}";
            return transformed;
        }

        private void WalletForm_Load(object sender, EventArgs e)
        {
            decimal amount = WalletService.GetWallet(userId).Amount;
            walletBalance.Text += amount.ToString();

            var stocks = WalletService.GetAvailableStocksWithValues();

            foreach(var stock in stocks)
            {
                string[] row = {stock.Key, stock.Value.ToString()};
                buyComboBox.Items.Add(stock.Key);
                buyStocksGridView.Rows.Add(row);
            }

            List<StockOwnership> sellStocks = WalletService.GetOwnedStocks(userId);

            foreach (StockOwnership stock in sellStocks)
            {
                if(stock.Quantity > 0 && stocks.ContainsKey(stock.StockSymbol)) 
                {
                    decimal value = stock.Quantity * stocks[stock.StockSymbol]; 
                    string[] row = { stock.StockSymbol, stock.Quantity.ToString(), stocks[stock.StockSymbol].ToString(), value.ToString() };
                    sellComboBox.Items.Add(stock.StockSymbol);
                    sellStocksGridView.Rows.Add(row);
                }
            }

            transactionComboBox.SelectedIndex = 0;
            buyComboBox.SelectedIndex = 0;
            try
            {
                sellComboBox.SelectedIndex = 0;
            }
            catch { }

            List<Transaction> transactions = WalletService.GetTransactions(userId);
            //koristimo posebnu lokalnu klasu koja sadrži uz sve podatke još i razliku između kupovne i prodajne vrijednosti
            List<TransactionVM> transactionVMs = new List<TransactionVM>();
            foreach(Transaction transaction in transactions)
            {
                TransactionVM transactionVM = new TransactionVM(transaction.TransactionId, transaction.WalletId, transaction.StockSymbol,
                    transaction.StockAmount, transaction.Amount, transaction.Fee, transaction.DateTimeUTC, transaction.TransactionType);

                transactionVMs.Add(transactionVM);
            }
            dataGridTransactions.DataSource = transactionVMs;
            dataGridTransactions.Columns["WalletId"].Visible = false;

            dataGridTransactions.ClearSelection();
            buyStocksGridView.ClearSelection();
            sellStocksGridView.ClearSelection();
        }

        private void BuyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal amount = buyAmountSelector.Value;
            String stock = buyComboBox.Text;
            var stocks = WalletService.GetAvailableStocksWithValues();
            try
            {
                decimal value = amount * stocks[stock];
                costLabel.Text = "Cost: " + value.ToString();
            }
            catch
            {
                costLabel.Text = "Cost: 0";
            }
        }

        private void BuyAmountSelector_ValueChanged(object sender, EventArgs e)
        {
            decimal amount = buyAmountSelector.Value;
            String stock = buyComboBox.Text;
            var stocks = WalletService.GetAvailableStocksWithValues();
            try
            {
                decimal value = amount * stocks[stock];
                costLabel.Text = "Cost: " + value.ToString();
            }
            catch
            {
                costLabel.Text = "Cost: 0";
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            decimal amount = buyAmountSelector.Value;
            if (amount > 0)
            {
                String stock = buyComboBox.Text;

                bool successful = WalletService.BuyStock(userId, stock, amount);
                if (successful)
                {
                    decimal walletAmount = WalletService.GetWallet(userId).Amount;
                    walletBalance.Text = "Wallet balance: " + walletAmount.ToString();
                    buyResultLabel.Text = "Stocks bought successfully.";
                    sellStocksGridView.Rows.Clear();
                    List<StockOwnership> sellStocks = WalletService.GetOwnedStocks(userId);
                    var stocks = WalletService.GetAvailableStocksWithValues();
                    sellComboBox.Items.Clear();

                    foreach (StockOwnership s in sellStocks)
                    {
                        if(s.Quantity > 0)
                        {
                            decimal value = s.Quantity * stocks[s.StockSymbol];
                            string[] row = { s.StockSymbol, s.Quantity.ToString(), stocks[s.StockSymbol].ToString(), value.ToString() };
                            sellComboBox.Items.Add(s.StockSymbol);
                            sellStocksGridView.Rows.Add(row);
                        }
                    }
                    //poruku prikazujemo samo na nekoliko sekundi
                    System.Timers.Timer timer = new System.Timers.Timer(2000);
                    timer.Elapsed += (_, __) => buyResultLabel.Invoke((MethodInvoker)(() => buyResultLabel.Text = ""));
                    timer.AutoReset = false;
                    timer.Start();
                    TransactionComboBox_SelectedIndexChanged(sender, e);
                }
                else
                {
                    //poruku prikazujemo samo na nekoliko sekundi
                    buyResultLabel.Text = "Stocks not bought. Try again.";
                    System.Timers.Timer timer = new System.Timers.Timer(2000);
                    timer.Elapsed += (_, __) => buyResultLabel.Invoke((MethodInvoker)(() => buyResultLabel.Text = ""));
                    timer.AutoReset = false;
                    timer.Start();
                }
            }
        }

       

        private void SellComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal amount = sellAmountSelector.Value;
            String stock = sellComboBox.Text;
            var stocks = WalletService.GetAvailableStocksWithValues();

            try
            {
                decimal value = amount * stocks[stock];
                sellValueLabel.Text = "Value: " + value.ToString();
            }
            catch
            {
                sellValueLabel.Text = "Value: 0";
            }
        }

        private void SellAmountSelector_ValueChanged(object sender, EventArgs e)
        {
            decimal amount = sellAmountSelector.Value;
            String stock = sellComboBox.Text;
            var stocks = WalletService.GetAvailableStocksWithValues();

            try
            {
                decimal value = amount * stocks[stock];
                sellValueLabel.Text = "Value: " + value.ToString();
            }
            catch
            {
                sellValueLabel.Text = "Value: 0";
            }
        }


        private void SellButton_Click(object sender, EventArgs e)
        {
            decimal amount = sellAmountSelector.Value;
            if (amount > 0)
            {
                String stock = sellComboBox.Text;

                int successful = WalletService.SellStock(userId, stock, amount);
                if (successful == 1)
                {
                    decimal walletAmount = WalletService.GetWallet(userId).Amount;
                    walletBalance.Text = "Wallet balance: " + walletAmount.ToString();
                    sellResultLabel.Text = "Stocks sold successfully.";
                    sellStocksGridView.Rows.Clear();
                    List<StockOwnership> sellStocks = WalletService.GetOwnedStocks(userId);
                    var stocks = WalletService.GetAvailableStocksWithValues();
                    //izbrišemo sve dionice pa ih ponovno stavimo u ComboBox u slučaju da su sve
                    //dionice iste vrste prodane
                    sellComboBox.Items.Clear();
                    sellAmountSelector.Value = 0;
                    sellValueLabel.Text = "Value: 0";

                    foreach (StockOwnership s in sellStocks)
                    {
                        if(s.Quantity > 0)
                        {
                            decimal value = s.Quantity * stocks[s.StockSymbol];
                            string[] row = { s.StockSymbol, s.Quantity.ToString(), stocks[s.StockSymbol].ToString(), value.ToString() };
                            sellComboBox.Items.Add(s.StockSymbol);
                            sellStocksGridView.Rows.Add(row);
                        }
                    }
                    //poruku prikazujemo samo na nekoliko sekundi
                    System.Timers.Timer timer = new System.Timers.Timer(2000);
                    timer.Elapsed += (_, __) => sellResultLabel.Invoke((MethodInvoker)(() => sellResultLabel.Text = ""));
                    timer.AutoReset = false;
                    timer.Start();
                    TransactionComboBox_SelectedIndexChanged(sender, e);
                }
                else if(successful == 0)
                {
                    //poruku prikazujemo samo na nekoliko sekundi
                    sellResultLabel.Text = "You do not own " + sellAmountSelector.Value.ToString() + " of " + sellComboBox.Text + " stocks";
                    System.Timers.Timer timer = new System.Timers.Timer(2000);
                    timer.Elapsed += (_, __) => sellResultLabel.Invoke((MethodInvoker)(() => sellResultLabel.Text = ""));
                    timer.AutoReset = false;
                    timer.Start();
                }
                else 
                {
                    //poruku prikazujemo samo na nekoliko sekundi
                    sellResultLabel.Text = "You do not own any " + sellComboBox.Text + " stocks";
                    System.Timers.Timer timer = new System.Timers.Timer(2000);
                    timer.Elapsed += (_, __) => sellResultLabel.Invoke((MethodInvoker)(() => sellResultLabel.Text = ""));
                    timer.AutoReset = false;
                    timer.Start();
                }
            }
        }

        private void TransactionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Transaction> transactions = WalletService.GetTransactions(userId);
            if (transactionComboBox.SelectedIndex == 1)
            {
                List<TransactionVM> buyList = new List<TransactionVM>();
                foreach (var transaction in transactions)
                {
                    if (transaction.TransactionType == TransactionTypeEnum.Buy)
                    {
                        TransactionVM transactionVM = new TransactionVM(transaction.TransactionId, transaction.WalletId, transaction.StockSymbol,
                        transaction.StockAmount, transaction.Amount, transaction.Fee, transaction.DateTimeUTC, transaction.TransactionType);

                        buyList.Add(transactionVM);
                    }
                }
                dataGridTransactions.DataSource = buyList;
            }
            else if (transactionComboBox.SelectedIndex == 2)
            {
                List<TransactionVM> sellList = new List<TransactionVM>();
                foreach (var transaction in transactions)
                {
                    if (transaction.TransactionType == TransactionTypeEnum.Sell)
                    {
                        TransactionVM transactionVM = new TransactionVM(transaction.TransactionId, transaction.WalletId, transaction.StockSymbol,
                        transaction.StockAmount, transaction.Amount, transaction.Fee, transaction.DateTimeUTC, transaction.TransactionType);

                        sellList.Add(transactionVM);
                    }
                }
                dataGridTransactions.DataSource = sellList;
            }
            else
            {
                List<TransactionVM> transactionVMs = new List<TransactionVM>();
                foreach (Transaction transaction in transactions)
                {
                    TransactionVM transactionVM = new TransactionVM(transaction.TransactionId, transaction.WalletId, transaction.StockSymbol,
                        transaction.StockAmount, transaction.Amount, transaction.Fee, transaction.DateTimeUTC, transaction.TransactionType);

                    transactionVMs.Add(transactionVM);
                }
                dataGridTransactions.DataSource = transactionVMs;
            }
            dataGridTransactions.Columns.Remove("WalletId");
            dataGridTransactions.Columns[0].HeaderText = "Transaction Number";
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            using(TransferForm transferForm = new TransferForm(userId))
            {
                //nakon uplate ili isplate osvježimo stanje računa
                if(transferForm.ShowDialog() == DialogResult.OK)
                {
                    decimal walletAmount = WalletService.GetWallet(userId).Amount;
                    walletBalance.Text = "Wallet balance: " + walletAmount.ToString();
                }
            }
        }

        private void FrontPageButton_Click(object sender, EventArgs e)
        {
            FrontPage page = new FrontPage(userId);
            Hide();
            page.ShowDialog();
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

    //klasa iste funkcionalnosti kao i klasa Transaction, ali s dodatnim svojstvom
    //da sadrži razliku između kupovne i prodajne vrijednosti
    public class TransactionVM
    {
        public int TransactionId { get; set; }
        public int WalletId { get; set; }
        public string StockSymbol { get; set; }
        public decimal StockAmount { get; set; }
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
        public DateTime DateTimeUTC { get; set; }
        public TransactionTypeEnum TransactionType { get; set; }
        public decimal Difference { get; }

        public TransactionVM(int transactionId, int walletId, string stockSymbol, decimal stockAmount, decimal amount, decimal fee, DateTime date, TransactionTypeEnum transactionType)
        {
            TransactionId = transactionId;
            WalletId = walletId;
            StockSymbol = stockSymbol;
            StockAmount = stockAmount;
            Amount = amount;
            Fee = fee;
            DateTimeUTC = date;
            TransactionType = transactionType;

            if (transactionType == TransactionTypeEnum.Sell)
            {
                decimal currentValue = BrokerService.GetStockInfo(stockSymbol, DateTimeUTC.Date).Price;
                decimal pastValue = WalletService.GetTransactionValue(walletId, stockSymbol);

                Difference = currentValue - pastValue;
            }
            else
            {
                decimal currentValue = BrokerService.GetStockInfo(stockSymbol, DateTime.UtcNow.Date).Price;
                decimal pastValue = BrokerService.GetStockInfo(stockSymbol, DateTimeUTC.Date).Price;

                Difference = currentValue - pastValue;
            }
        }
    }
}
