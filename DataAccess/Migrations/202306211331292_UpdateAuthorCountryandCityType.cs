namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAuthorCountryandCityType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorCountryID", c => c.Int(nullable: false));
            AddColumn("dbo.Authors", "AuthorCityID", c => c.Int(nullable: false));
            CreateIndex("dbo.Authors", "AuthorCountryID");
            CreateIndex("dbo.Authors", "AuthorCityID");
            AddForeignKey("dbo.Authors", "AuthorCityID", "dbo.Cities", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Authors", "AuthorCountryID", "dbo.Countries", "ID", cascadeDelete: false);
            DropColumn("dbo.Authors", "AuthorCountry");
            DropColumn("dbo.Authors", "AuthorCity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Authors", "AuthorCity", c => c.String(nullable: false));
            AddColumn("dbo.Authors", "AuthorCountry", c => c.String(nullable: false));
            DropForeignKey("dbo.Authors", "AuthorCountryID", "dbo.Countries");
            DropForeignKey("dbo.Authors", "AuthorCityID", "dbo.Cities");
            DropIndex("dbo.Authors", new[] { "AuthorCityID" });
            DropIndex("dbo.Authors", new[] { "AuthorCountryID" });
            DropColumn("dbo.Authors", "AuthorCityID");
            DropColumn("dbo.Authors", "AuthorCountryID");
        }
    }
}
