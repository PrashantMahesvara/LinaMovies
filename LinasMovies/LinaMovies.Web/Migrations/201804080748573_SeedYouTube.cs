namespace LinaMovies.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedYouTube : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Dragonheart', 'N/A', '1996', '103', 'Dennis Quiad spelar riddaren Bown och Sean Connery spelar Draco', 0, 3, 3 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('The Nutty Professor', 'Den galna professorn', '21996', '95', 'Bara ett test', 0, 6, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('The 40-year Old Virgin', '40-åriga oskulden', '2005', '116', 'Bara ett test', 0, 6, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Back to the Future', 'Tillbaka till framtiden', '1985', '116', 'Bara ett test', 0, 3, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Who Framed Roger Rabbit', '', '1988', '104', '', 0, 3, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Hellboy 2: The Golden Army', '', '2008', '120', '', 0, 1, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Silence of the Lambs', 'När lammen tystnar', '1991', '118', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('The Mummy', 'Mumien', '2018', '104', 'Bara ett test', 1, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('The Mummy Returns', 'Mumien återkomsten', '2001', '130', 'Bara ett test', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('The Mummy: Tomb of the Dragon Emperor', 'Mumien: Drakkejsarens grav', '2008', '112', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Real Steel', '', '2011', '127', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Kung Fu Panda 2', '', '2011', '90', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Jumanji', 'Default2', '1995', '104', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Fun With Dick and Jane', '', '2005', '90', '', 1, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('I am Number Four', '', '2011', '111', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Amnetyville Horror', 'Huset som Gud glömde', '2005', '90', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Tomten är far till alla barnen', 'In Bed with Santa', '1999', '95', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Shark Tale', 'Default2', '2004', '90', '', 1, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('The Ant bully', 'Myrmobbaren', '2006', '88', '', 1, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Jönssonligan och den svarta diamanten', '', '1992', '104', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Transformers: Age of Extinction', '', '2014', '165', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Abraham Lincoln: Vampire Hunter', '', '2012', '105', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Osmosis Jones', '', '2001', '95', '', 1, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Robots', 'Robotar', '2005', '91', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('A Good Day to Die Hard', 'Die Hard 5', '2013', '98', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Confessions of a Shopaholic', 'en shopaholics bekännelser', '2009', '104', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Identity Theif', '', '2013', '111', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Clueless', '', '1995', '97', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Percy Jackson & the Olympians: The Lightning Thief', 'Percy Jackson och kampen om åskviggen', '2010', '118', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('The Spiderwick Chronicles', '', '2008', '96', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Cowboys & Aliens', 'Default2', '2011', '119', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('John Wick', '', '2014', '101', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Ghostbusters', '', '1984', '105', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Ghostbusters 2', 'Ghostbusters II', '1989', '108', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Casper', '', '1995', '100', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Deuce Bigalow: Male Gigolo', 'Hollywood gigolo', '1999', '88', 'Bara ett test', 1, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Hot Shots: Part Deux', '', '1993', '86', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Den ofrivillige golfaren', '', '1991', '107', '', 0, 3, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('The Magic Sword: Quest for Camelot', 'Svärdet i stenen', '1998', '86', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('9 To 5', '9 till 5', '1980', '104', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Meet the Fockers', 'Familjen är värre', '2004', '115', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Meet the Parents', 'Släkten är värst', '2000', '104', 'Bara ett test', 1, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Chronicles of Narnia: The Lion, The Witch and the Wardrobe', '', '2005', '143', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Nothing to Lose', '', '1997', '98', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Norbit', '', '2007', '102', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Blended', '', '2014', '117', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Ace Ventura: Pet Detective', 'Den galopperande detektiven', '1994', '84', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Ace Ventura: When Nature Calls', 'Den galopperande detektiven rider igen', '1995', '90', '', 0, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Ice Age', '', '2002', '81', '', 1, 3, 2 )");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Green Lantern', '', '2011', '116', '', 0, 3, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Gremlings 2: The New Batch', 'Gremlings 2', '1990', '106', '', 0, 3, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Eight Below', '', '2006', '120', '', 0, 3, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Sällskapsresan eller Finns det svenskt kaffe på grisfesten', 'Sällskapsresan', '1980', '174', '', 0, 3, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Snowroller: Sällskapsresan II ', 'Sällskapsresan 2', '1985', '91', '', 0, 3, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Hook', '', '1991', '142', '', 0, 3, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Cocktail', '', '1998', '104', '', 0, 3, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Pretty Woman', '', '1990', '119', '', 0, 3, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Armageddon', '', '1998', '151', '', 0, 3, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Pitch Black', '', '2000', '109', '', 0, 1, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Jaws', 'Hajen', '2000', '109', '', 0, 1, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Beethooven', 'Beethoven', '2000', '109', '', 0, 1, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('101 Dalmatins', '101 dalmatinerna', '2000', '109', '', 0, 1, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Taken', '', '2000', '109', '', 0, 1, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Cats & Dogs', '', '2000', '109', '', 0, 1, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Space Jam', '', '2000', '109', '', 0, 1, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Wrath of the Titans', '', '2012', '109', '', 0, 1, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Dennis the Menace', '', '2000', '109', '', 0, 1, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Deep Blue Sea', 'Djuptblått hav', '2000', '109', '', 0, 1, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Clash of the Titans', '', '2010', '109', '', 0, 1, 3)");
            Sql("INSERT INTO Movies (Title, AltTitle, Released, RunningTimeInMinutes, Description, Animated, GenreId, FormatId) VALUES ('Hannibal Rising', 'Hannibal Rising: Ondskan vaknar', '2000', '109', '', 0, 1, 3)");
        }

        public override void Down()
        {
        }
    }
}
