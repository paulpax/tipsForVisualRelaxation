namespace tipsForVisualRelaxation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMovie : DbMigration
    {
        public override void Up()
        {
            Sql("DBCC CHECKIDENT('Movie', RESEED, 0)");
            Sql("INSERT INTO Movie (Name, ReleaseDate, GenreId) VALUES ('The First Purge', CONVERT(datetime, '7/4/2018'), 3)");
            Sql("INSERT INTO Movie (Name, ReleaseDate, GenreId) VALUES ('The Purge: Election Year', CONVERT(datetime, '6/29/2016'), 3)");
            Sql("INSERT INTO Movie (Name, ReleaseDate, GenreId) VALUES ('Good Boys', CONVERT(datetime, '1/1/2019'), 1)");
            Sql("INSERT INTO Movie (Name, ReleaseDate, GenreId) VALUES ('Matrix', CONVERT(datetime, '1/1/1999'), 2)");
            Sql("INSERT INTO Movie (Name, ReleaseDate, GenreId) VALUES ('12 Years a slave', CONVERT(datetime, '1/1/2013'), 4)");
            Sql("INSERT INTO Movie (Name, ReleaseDate, GenreId) VALUES ('Citizenfour', CONVERT(datetime, '1/1/2014'), 5)");
        }
        
        public override void Down()
        {
        }
    }
}
