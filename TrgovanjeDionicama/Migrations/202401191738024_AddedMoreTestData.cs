namespace TrgovanjeDionicama.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMoreTestData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Wallets(UserId, CurrencyCode, Amount) VALUES" +
                "(1, 'EUR', 1000.00), (2, 'EUR', 1500.00), (3, 'EUR', 2000.00)");
        }
        
        public override void Down()
        {
        }
    }
}
