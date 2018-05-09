namespace LinaMovies.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedViaPlay : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Iron Man 3', '', '2013', '130', '', 0, 3, 4)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Wreck-It Ralph', 'Röjar-Ralf', '2012', '101', '', 1, 3, 4)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('The Jungle Book', 'Djungelboken', '1967', '78', '', 1, 3, 4 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Toy Story 2', '', '1999', '92', '', 1, 3, 4 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Toy Story 3', '', '2010', '103', '', 1, 3, 4 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Cinderella', 'Askungen', '1950', '74', 'Bara ett test', 1, 3, 4 )");
        }
        
        public override void Down()
        {
        }
    }
}
