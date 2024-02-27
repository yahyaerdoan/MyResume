namespace MyResume.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRequiredAllTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Skills", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Skills", "Icon", c => c.String(nullable: false));
            AlterColumn("dbo.Skills", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Skills", "Description", c => c.String());
            AlterColumn("dbo.Skills", "Icon", c => c.String());
            AlterColumn("dbo.Skills", "Title", c => c.String());
        }
    }
}
