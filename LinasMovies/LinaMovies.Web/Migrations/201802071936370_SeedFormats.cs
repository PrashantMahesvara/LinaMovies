namespace LinaMovies.Web.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class SeedFormats : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Formats (Id, Name) VALUES (1, 'Blueray')");
            Sql("INSERT INTO Formats (Id, Name) VALUES (2, 'DVD')");
            Sql("INSERT INTO Formats (Id, Name) VALUES (3, 'YouTube')");
            Sql("INSERT INTO Formats (Id, Name) VALUES (4, 'Viaplay')");
            Sql("INSERT INTO Formats (Id, Name) VALUES (5, 'VHS')");
            Sql("INSERT INTO Formats (Id, Name) VALUES (6, 'Other')");
        }

        public override void Down()
        {
        }
    }
}
