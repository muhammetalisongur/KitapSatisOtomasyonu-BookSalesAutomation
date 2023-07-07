namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBookPrice : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "BookPrice", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "BookPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
