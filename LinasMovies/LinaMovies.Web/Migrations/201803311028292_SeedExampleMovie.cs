namespace LinaMovies.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedExampleMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Example movie 1', 'Exempelfilm 1', '2018', '104', 'Bara ett test', 1, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Example movie 2', 'Exempelfilm 2', 2018, 104, 'Bara ett annat test', 2, 1, 5 )");

        }


        public override void Down()
        {
        }
    }
}
