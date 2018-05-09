namespace LinaMovies.Web.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Äventyr')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Skräck')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Komedi')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Familjefilm')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Western')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Dokumentär')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Romantik')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'Sci-fi')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (12, 'Musikal')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (13, 'Krigsfilm')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (14, 'Romantisk komedi')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (15, 'Anime')");
        }

        public override void Down()
        {
        }
    }
}
