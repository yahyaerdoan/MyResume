namespace MyResume.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStatu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SocialMedias", "Statu", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SocialMedias", "Statu");
        }
    }
}
