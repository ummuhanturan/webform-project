﻿namespace P.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Exams", "TeacherId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Exams", "TeacherId");
        }
    }
}
