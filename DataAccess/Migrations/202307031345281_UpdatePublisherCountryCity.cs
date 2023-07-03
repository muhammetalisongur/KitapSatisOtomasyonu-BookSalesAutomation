namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePublisherCountryCity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Publishers", "PublisherCountryID", c => c.Int(nullable: false));
            AddColumn("dbo.Publishers", "PublisherCityID", c => c.Int());
            CreateIndex("dbo.Publishers", "PublisherCountryID");
            CreateIndex("dbo.Publishers", "PublisherCityID");
            AddForeignKey("dbo.Publishers", "PublisherCityID", "dbo.Cities", "ID");
            AddForeignKey("dbo.Publishers", "PublisherCountryID", "dbo.Countries", "ID", cascadeDelete: true);
            DropColumn("dbo.Publishers", "PublisherCountry");
            DropColumn("dbo.Publishers", "PublisherCity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Publishers", "PublisherCity", c => c.String(nullable: false));
            AddColumn("dbo.Publishers", "PublisherCountry", c => c.String(nullable: false));
            DropForeignKey("dbo.Publishers", "PublisherCountryID", "dbo.Countries");
            DropForeignKey("dbo.Publishers", "PublisherCityID", "dbo.Cities");
            DropIndex("dbo.Publishers", new[] { "PublisherCityID" });
            DropIndex("dbo.Publishers", new[] { "PublisherCountryID" });
            DropColumn("dbo.Publishers", "PublisherCityID");
            DropColumn("dbo.Publishers", "PublisherCountryID");
        }
    }
}
