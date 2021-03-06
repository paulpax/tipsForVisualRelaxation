﻿namespace tipsForVisualRelaxation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Genre", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Movie", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movie", "Name", c => c.String());
            AlterColumn("dbo.Genre", "Name", c => c.String());
        }
    }
}
