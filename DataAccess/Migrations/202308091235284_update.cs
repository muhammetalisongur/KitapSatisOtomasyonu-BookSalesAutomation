namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "BookSale", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "BookSale", c => c.Int(nullable: false));
        }
    }
}
