using System;

namespace TrgovanjeDionicama
{
    internal class Transaction
    {
        public int TransactionId { get; set; }
        public int WalletId { get; set; }
        public string StockSymbol { get; set; }
        public decimal StockAmount { get; set; }
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
        public DateTime DateTimeUTC { get; set; }
        public TransactionTypeEnum TransactionType { get; set; }

        public Transaction() { }

        public Transaction(int walletId, string stockSymbol, decimal stockAmount, decimal amount, decimal fee, TransactionTypeEnum transactionType)
        {
            WalletId = walletId;
            StockSymbol = stockSymbol;
            StockAmount = stockAmount;
            Amount = amount;
            Fee = fee;
            DateTimeUTC = DateTime.UtcNow;
            TransactionType = transactionType;
        }

    }

    public enum TransactionTypeEnum 
    {
        Sell = 1,
        Buy = 2
    }
}
