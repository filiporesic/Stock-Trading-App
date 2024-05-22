using System;
using System.Collections.Generic;
using System.Linq;

namespace TrgovanjeDionicama
{
    internal static class BrokerService
    {
        static DateTime minDateSupported = new DateTime(2023, 11, 1);
        private static readonly Random random = new Random();
        
        /// <summary>
        ///Gets all stock data on the given date 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static List<Stock> GetAllStocksByDate(DateTime date)
        {
            using (var context = new StockExchangeDbContext())
            {
                return context.Stocks.Where(x => x.Date == date.Date).ToList();
            }
        }
        /// <summary>
        /// Gets stock info for stock symbol on the given date 
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static Stock GetStockInfo(string symbol, DateTime date)
        {
            using (var context = new StockExchangeDbContext())
            {
                return context.Stocks.FirstOrDefault(x => x.Symbol == symbol && x.Date == date);
            }
        }
        /// <summary>
        /// Mocks stock data since minDateSupported
        /// </summary>
        public static void MockStockData()
        {
            using (var context = new StockExchangeDbContext())
            {
                var maxInDb = context.Stocks.Max(x => x.Date);
                DateTime minDate = maxInDb < minDateSupported ? minDateSupported : maxInDb;
                int days = (DateTime.UtcNow - minDate).Days;
                List<Stock> stocks = new List<Stock>();
                for (int i = 1; i <= days; i++)
                {
                    foreach (string symbol in GetExampleSymbols())
                    {
                        decimal initialPrice = GetInitialPrice(symbol);
                        decimal randomChange = GetRandomChange();
                        decimal newPrice = initialPrice * (1 + randomChange);
                        stocks.Add(new Stock
                        {
                            Symbol = symbol,
                            Date = minDate.AddDays(i),
                            Price = newPrice,
                            Name = GetName(symbol),
                        });
                    }
                }
                context.Stocks.AddRange(stocks);
                context.SaveChanges();
            }
        }

        #region HelperMethods
        /// <summary>
        /// Gets supported stock symbols
        /// </summary>
        /// <returns>list of supported symbols</returns>
        private static IEnumerable<string> GetExampleSymbols()
        {
            return new List<string> { "AAPL", "MSFT", "GOOGL", "AMZN", "TSLA", "FB", "NVDA", "V", "PYPL", "NFLX" };
        }

        /// <summary>
        /// Gets initial price of only supported stock symbols or default price of 100 (needs improvement in the future)
        /// </summary>
        /// <param name="symbol"></param>
        private static decimal GetInitialPrice(string symbol)
        {
            switch (symbol)
            {
                case "AAPL": return 150.00m;
                case "MSFT": return 250.00m;
                case "GOOGL": return 2200.00m;
                case "AMZN": return 3100.00m;
                case "TSLA": return 700.00m;
                case "FB": return 330.00m;
                case "NVDA": return 600.00m;
                case "V": return 220.00m;
                case "PYPL": return 250.00m;
                case "NFLX": return 550.00m;
                default: return 100.00m;
            }
        }

        /// <summary>
        /// Get hardcoded names for stock symbols
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns>string which represents stock name</returns>
        private static string GetName(string symbol)
        {
            switch (symbol)
            {
                case "AAPL": return "Apple Inc.";
                case "MSFT": return "Microsoft Corporation";
                case "GOOGL": return "Alphabet Inc.";
                case "AMZN": return "Amazon.com, Inc.";
                case "TSLA": return "Tesla, Inc.";
                case "FB": return "Meta Platforms, Inc."; 
                case "NVDA": return "NVIDIA Corporation";
                case "V": return "Visa Inc.";
                case "PYPL": return "PayPal Holdings, Inc.";
                case "NFLX": return "Netflix, Inc.";
                default: return "Unknown";
            }
        }

        /// <summary>
        /// Gets random percentage change between -5% and +5%
        /// </summary>
        /// <returns></returns>
        private static decimal GetRandomChange()
        {
            // Generate a random percentage change between -5% and +5%
            return ((decimal)random.NextDouble() - 0.5m) * 0.1m;
        }
        #endregion
    }
}
