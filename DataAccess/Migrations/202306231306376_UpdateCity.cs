namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCity : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Cities", new[] { "CountryID" });
            AlterColumn("dbo.Cities", "CountryID", c => c.Int());
            CreateIndex("dbo.Cities", "CountryID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Cities", new[] { "CountryID" });
            AlterColumn("dbo.Cities", "CountryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Cities", "CountryID");
        }
    }
}
