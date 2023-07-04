namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBookPublisherDate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "BookPublishDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "BookPublishDate", c => c.Int(nullable: false));
        }
    }
}
