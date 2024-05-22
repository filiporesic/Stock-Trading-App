namespace TrgovanjeDionicama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTableStockOwnerships : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockOwnerships",
                c => new
                    {
                        StockOwnershipId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        StockSymbol = c.String(),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.StockOwnershipId);
            
            AddColumn("dbo.Transactions", "TransactionType", c => c.Int(nullable: false));
            AlterColumn("dbo.Transactions", "StockSymbol", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "StockSymbol", c => c.Int(nullable: false));
            DropColumn("dbo.Transactions", "TransactionType");
            DropTable("dbo.StockOwnerships");
        }
    }
}
