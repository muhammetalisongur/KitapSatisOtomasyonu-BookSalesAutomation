namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookSaleTableAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "BookSale", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "BookSale");
        }
    }
}
