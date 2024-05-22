using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrgovanjeDionicama
{
    internal static class WalletService
    {
        public static Wallet GetWallet(int userId)
        {
            using (var context = new StockExchangeDbContext())
            {
                var wallet = context.Wallets.FirstOrDefault(x => x.UserId == userId);
                return wallet;
            }
        }

        public static void UpdateWallet(int userId, decimal amount)
        {
            using (var context = new StockExchangeDbContext())
            {
                var wallet = context.Wallets.FirstOrDefault(x => x.UserId == userId);
                wallet.Amount = amount;
                context.SaveChanges();
            }
        }

        public static void DepositToWallet(int userId, decimal amount)
        {
            using (var context = new StockExchangeDbContext())
            {
                var wallet = context.Wallets.FirstOrDefault(x => x.UserId == userId);
                wallet.Amount += amount;
                context.SaveChanges();
            }
        }

        public static void WithdrawToBankAccount(int userId, decimal amount)
        {
            using (var context = new StockExchangeDbContext())
            {
                var wallet = context.Wallets.FirstOrDefault(x => x.UserId == userId);
                wallet.Amount -= amount;
                context.SaveChanges();
            }
        }

        public static Dictionary<string, decimal> GetAvailableStocksWithValues()
        {
            using (var context = new StockExchangeDbContext()) 
            {
                var date = DateTime.UtcNow.Date;
                return context.Stocks.Where(stock => stock.Date == date).ToDictionary(stock => stock.Symbol, stock => stock.Price);
            }
        }

        public static List<StockOwnership> GetOwnedStocks(int userId)
        {
            List<StockOwnership> stocks;
            using (var context = new StockExchangeDbContext())
            {
                
                stocks = context.StockOwnerships.Where(x => x.UserId == userId).OrderBy(x => x.StockSymbol).ToList();
            }

            return stocks;
        }

        public static decimal GetTransactionValue(int walletId, string symbol)
        {
            using (var context = new StockExchangeDbContext())
            {
                bool exist = context.Transactions.Any(x => x.WalletId == walletId && x.StockSymbol == symbol && x.TransactionType == TransactionTypeEnum.Buy);
                if(!exist)
                    return 0;
                decimal value = context.Transactions.First(x => x.WalletId == walletId && x.StockSymbol == symbol && x.TransactionType == TransactionTypeEnum.Buy).Amount;
                return value;
            }
        }

        public static bool BuyStock(int userId, string stockSymbol, decimal stockQuantity)
        {
            using (var context = new StockExchangeDbContext())
            {
                var wallet = GetWallet(userId);
                decimal amount = wallet.Amount;
                DateTime date = DateTime.UtcNow.Date;
                decimal value = context.Stocks.First(x => x.Symbol == stockSymbol && x.Date == date).Price;
                if (amount >= stockQuantity * value)
                {
                    amount -= stockQuantity * value;

                    UpdateWallet(userId, amount);
                    
                    Transaction transaction = new Transaction(wallet.WalletId, stockSymbol, stockQuantity, stockQuantity * value, 0, TransactionTypeEnum.Buy);
                    context.Transactions.Add(transaction);
                    
                    bool exist = context.StockOwnerships.Any(x => x.UserId == userId && x.StockSymbol == stockSymbol);
                    if (exist)
                    {
                        var stockOwnership = context.StockOwnerships.First(x => x.UserId == userId && x.StockSymbol == stockSymbol);
                        stockOwnership.Quantity += stockQuantity;
                    }
                    else
                    {
                        StockOwnership stockOwnership = new StockOwnership(userId, stockSymbol, stockQuantity);
                        context.StockOwnerships.Add(stockOwnership);
                    }
                    
                    context.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
        }

        public static int SellStock(int userId, string stockSymbol, decimal stockQuantity)
        {
            using (var context = new StockExchangeDbContext())
            {
                var stockOwnership = context.StockOwnerships.FirstOrDefault(x => x.UserId == userId && x.StockSymbol == stockSymbol);
                if (stockOwnership == null)
                    return -1;
                else if (stockOwnership.Quantity < stockQuantity)
                    return 0;
                else
                {
                    var wallet = GetWallet(userId);
                    DateTime date = DateTime.UtcNow.Date;
                    decimal value = context.Stocks.First(x => x.Symbol == stockSymbol && x.Date == date).Price;
                    decimal amount = wallet.Amount + stockQuantity * value * 0.98M;
                    UpdateWallet(userId, amount);

                    int walletId = wallet.WalletId;
                    Transaction transaction = new Transaction(walletId, stockSymbol, stockQuantity,
                        stockQuantity * value, stockQuantity * value * 0.02M, TransactionTypeEnum.Sell);
                    context.Transactions.Add(transaction);

                    stockOwnership.Quantity -= stockQuantity;
                    
                    context.SaveChanges();

                    return 1;
                }
            }
        }

        public static List<Transaction> GetTransactions(int userId)
        {
            using (var context = new StockExchangeDbContext())
            {
                int walletId = GetWallet(userId).WalletId;
                bool exist = context.Transactions.Any(x => x.WalletId == walletId);
                if (exist)
                {
                    List<Transaction> transactions = context.Transactions.Where(x => x.WalletId == walletId).ToList();
                    return transactions;
                }
                return new List<Transaction>();
            }
        }

        public static decimal CalculatePortfolioWorth(int userId) 
        {
            using (var context = new StockExchangeDbContext()) 
            {
                var valuesDict = GetAvailableStocksWithValues();
                var stocks = context.StockOwnerships.Where(x => x.UserId == userId).ToList();
                decimal value = 0;
                foreach (var stock in stocks) 
                {
                    if(!valuesDict.ContainsKey(stock.StockSymbol))
                        continue;
                    value += valuesDict[stock.StockSymbol] * stock.Quantity;
                }
                return value;
            }
        }

        public static decimal CalculatePortfolioWorthYesterday(int userId)
        {
            using (var context = new StockExchangeDbContext())
            {
                var date = DateTime.UtcNow.Date.AddDays(-1);
                var valuesDict = context.Stocks.Where(stock => stock.Date == date).ToDictionary(stock => stock.Symbol, stock => stock.Price);
                var stocks = context.StockOwnerships.Where(x => x.UserId == userId).ToList();
                decimal value = 0;
                foreach (var stock in stocks)
                {
                    if (!valuesDict.ContainsKey(stock.StockSymbol))
                        continue;
                    value += valuesDict[stock.StockSymbol] * stock.Quantity;
                }
                return value;
            }
        }
    }
}
