using System;

namespace TrgovanjeDionicama
{
    internal class Stock
    {
        public int StockId { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
