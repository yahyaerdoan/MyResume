namespace MyResume.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Skills", "Rate", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Skills", "Rate");
        }
    }
}
