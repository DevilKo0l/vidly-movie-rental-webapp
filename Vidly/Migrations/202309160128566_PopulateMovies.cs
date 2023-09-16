namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (1, 'The Shawshank Redemption', 2, '2023/09/16', '1995/04/16', 20)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (2, 'The Matrix', 1, '2023/09/16', '1999/08/13', 15)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (3, 'Spirited Away', 9, '2023/09/16', '2001/07/20',30)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (4, 'The Notebook',4, '2023/09/16', '2004/06/25', 8)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (5, 'The Conjuring', 7, '2023/09/16', '2013/07/26', 40)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
