namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Crime')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Fiction')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Animation')");            
        }
        
        public override void Down()
        {
        }
    }
}
