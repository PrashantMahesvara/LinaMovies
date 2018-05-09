namespace LinaMovies.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedBlueray : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Disturbia', '', '2007', '105', 'Shia LaBeof', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Hansel & Gretel', '', '2018', '104', 'Bara ett test', 1, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('I, Robot', '', '2004', '115', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Independence Day 1 & 2', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Men in Black trilogy', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Fried Green Tomatoes at Whistleblow Station', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Pompeii', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Avatar', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('The Lion King', 'Lejonkungen', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Thor', 'Tor', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Thor: The Dark World', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Thor: Ragnarök', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('San Andreas', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Man on Fire', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Shallow Hal', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Guardians of the Galaxy', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Guardians of the Galaxy vol. 2', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Hellboy', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('The League of Extraordianry Gentlemen', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Ghost', '', '2018', '104', 'Bara ett test', 1, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Jurassic Park Quadrilogy', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Fifth Element', 'Femte Elementet', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Forrest Gump', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Grease', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Miss Congeniality', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Miss Congeniality 2: Armed and Fabulous', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Noah', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Stardust', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('National Lampoons Vacation Collection', 'Ett päron till farsa', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Mama', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Liar Liar', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Price of Persia', '', '2018', '104', 'Bara ett test', 0, 1, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('The Hunger Games: Mocking Jay part 1', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Rio 2', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Transformers: The Last Knight', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Predator', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Predator 2', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Constantine', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Fantastic 4: Rise of the Silver Surfer', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Hotel Transylvania', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Hotel Transylvania 2', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Home', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Maleficent', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Big Momas House', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('A Good Day to Die Hard', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('The Call', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('E.T. - The Extraterrestial', '', '2018', '104', 'Bara ett test', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Sleeping with the Enemy', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Pirates of the Caribbean: At Worlds End', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Ghost Rider', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Ghost Rider: Spirit of Vengeance', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Underworld', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Underworld: Rise of the Lycans ', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Taken', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Avengers', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Avengers: Age of Ultron', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Hercules Extended', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Shrek 1', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Shrek 4', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Godzilla', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Resident Evil: Afterlife', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Hercules 3D', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Gravity', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Rise of the Guardians', 'De fem legenderna', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Antman', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Legend of the Guardians: Owls of Gahoole', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Paranorman', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Riddick', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Pacific Rim', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Transformers: Age of Extinction', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Ironman 1', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Ironman 2', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Lord of the Rings: The Fellowship of the Ring', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Lord of the Rings: The Two Towers', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Lord of the Rings: Return of the King', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Oz the Great and Powerful', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('X-men: Cerebro Collection', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Bad Teacher', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Charlie and the Chocolate factory', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Shawshank Redemption', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Titanic', '', '2018', '104', 'Bara ett test', 0, 3, 1)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Indiana Jones Quadrilogy', 'Indiana Jones 1-4', '2018', '104', 'Bara ett test', 0, 3, 1)");
        }

        public override void Down()
        {
        }
    }
}
