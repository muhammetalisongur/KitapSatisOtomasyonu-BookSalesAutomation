namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBook : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "BookImage", c => c.String());
            DropColumn("dbo.Books", "BookLanguage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "BookLanguage", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Books", "BookImage", c => c.String(nullable: false, maxLength: 250));
        }
    }
}
