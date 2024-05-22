using System.Data.Entity;

namespace TrgovanjeDionicama
{
    internal class StockExchangeDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<StockOwnership> StockOwnerships { get; set; }
    }
}
