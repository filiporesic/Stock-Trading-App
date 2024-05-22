namespace TrgovanjeDionicama
{
    internal class StockOwnership
    {
        public int StockOwnershipId { get; set; }
        public int UserId { get; set; }
        public string StockSymbol { get; set; }
        public decimal Quantity { get; set; }

        public StockOwnership() { }

        public StockOwnership(int userId, string symbol, decimal quantity)
        {
            UserId = userId;
            StockSymbol = symbol;
            Quantity = quantity;
        }

    }
}
