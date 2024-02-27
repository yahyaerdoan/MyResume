namespace MyResume.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRequiredForTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Skills", "Title", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Skills", "Title", c => c.String(nullable: false));
        }
    }
}
