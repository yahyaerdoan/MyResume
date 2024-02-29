namespace MyResume.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SocialMedias", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SocialMedias", "Name");
        }
    }
}
