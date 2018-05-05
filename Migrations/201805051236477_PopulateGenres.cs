namespace UdemyWebApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres (Id,Name)" +
                "VALUES (1,'Comedy')");
            Sql("INSERT INTO Genres (Id,Name)" +
                "VALUES (2,'Action')");
            Sql("INSERT INTO Genres (Id,Name)" +
                "VALUES (3,'Horror')");
            Sql("INSERT INTO Genres (Id,Name)" +
                "VALUES (4,'Family')");
            Sql("INSERT INTO Genres (Id,Name)" +
                "VALUES (5,'Romance')");
            Sql("SET IDENTITY_INSERT Genres OFF");
        }
        
        public override void Down()
        {
        }
    }
}
