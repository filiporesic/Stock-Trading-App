namespace TrgovanjeDionicama
{
    internal class Wallet
    {
        public int WalletId { get; set; }
        public int UserId { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Amount { get; set; }

        public Wallet() { }

        public Wallet(int userId, string currencyCode = "EUR") 
        {
            UserId = userId;
            CurrencyCode = currencyCode; 
            Amount = 0;
        }
    }
}
