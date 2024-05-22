namespace TrgovanjeDionicama.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTestData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Users (Username, PasswordHash, Email, FirstName, LastName, LastUpdatedAtUTC) VALUES" +
                "('dinko', '9f69a4beeb1fcb63d74cb64095e1f2295a85b060efe8707287ed1c182fe3bcdb', 'dmaduna@gmail.com', 'Dinko', 'Maduna', '2024-01-11')," +
                "('filip', 'ba6cdaa53ded44285963014c83dccacfe9e06e9b438763bc4ba1a23833edd477', 'foresic@gmail.com', 'Filip', 'Oresic', '2024-01-11')," +
                "('nina', 'a5c299e2fdd21869360a5e52cb764eafc7b94bd0eed0a2080c427684024242e0', 'nsalaj@gmail.com', 'Nina', 'Salaj', '2024-01-11')");
            Sql("INSERT INTO Stocks (Symbol, Name, Price, Date) VALUES " +
                "('AAPL', 'Apple Inc.', 150.00, '2023-11-01')," +
                "('MSFT', 'Microsoft Corporation', 250.00, '2023-11-01')," +
                "('GOOGL', 'Alphabet Inc.', 2200.00, '2023-11-01')," +
                "('AMZN', 'Amazon.com, Inc.', 3100.00, '2023-11-01')," +
                "('TSLA', 'Tesla, Inc.', 700.00, '2023-11-01')," +
                "('FB', 'Meta Platforms, Inc.', 330.00, '2023-11-01')," +
                "('NVDA', 'NVIDIA Corporation', 600.00, '2023-11-01')," +
                "('V', 'Visa Inc.', 220.00, '2023-11-01')," +
                "('PYPL', 'PayPal Holdings, Inc.', 250.00, '2023-11-01')," +
                "('NFLX', 'Netflix, Inc.', 550.00, '2023-11-01');");
        }
        
        public override void Down()
        {
        }
    }
}
