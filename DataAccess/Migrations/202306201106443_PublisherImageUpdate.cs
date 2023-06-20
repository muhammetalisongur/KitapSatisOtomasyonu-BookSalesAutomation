namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PublisherImageUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Publishers", "PublisherImage", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Publishers", "PublisherImage", c => c.String(nullable: false, maxLength: 250));
        }
    }
}
