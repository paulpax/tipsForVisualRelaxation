namespace tipsForVisualRelaxation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genre (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genre (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO Genre (Id, Name) VALUES (3, 'Thriller')");
            Sql("INSERT INTO Genre (Id, Name) VALUES (4, 'Historical')");
            Sql("INSERT INTO Genre (Id, Name) VALUES (5, 'Documentary')");
        }
        
        public override void Down()
        {
        }
    }
}
