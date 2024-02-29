﻿namespace MyResume.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStatuValue : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SocialMedias", "Statu", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SocialMedias", "Statu", c => c.String());
        }
    }
}
