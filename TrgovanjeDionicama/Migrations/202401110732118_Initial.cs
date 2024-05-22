namespace TrgovanjeDionicama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        StockId = c.Int(nullable: false, identity: true),
                        Symbol = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StockId);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        WalletId = c.Int(nullable: false),
                        StockSymbol = c.Int(nullable: false),
                        StockAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateTimeUTC = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        PasswordHash = c.String(),
                        Email = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        LastUpdatedAtUTC = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Wallets",
                c => new
                    {
                        WalletId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        CurrencyCode = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.WalletId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Wallets");
            DropTable("dbo.Users");
            DropTable("dbo.Transactions");
            DropTable("dbo.Stocks");
        }
    }
}
