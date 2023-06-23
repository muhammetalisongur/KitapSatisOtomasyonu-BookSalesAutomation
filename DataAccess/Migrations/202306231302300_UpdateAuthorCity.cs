namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAuthorCity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Authors", "AuthorCityID", "dbo.Cities");
            DropForeignKey("dbo.Cities", "CountryID", "dbo.Countries");
            DropIndex("dbo.Authors", new[] { "AuthorCityID" });
            AlterColumn("dbo.Authors", "AuthorCityID", c => c.Int());
            CreateIndex("dbo.Authors", "AuthorCityID");
            AddForeignKey("dbo.Authors", "AuthorCityID", "dbo.Cities", "ID");
            AddForeignKey("dbo.Cities", "CountryID", "dbo.Countries", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "CountryID", "dbo.Countries");
            DropForeignKey("dbo.Authors", "AuthorCityID", "dbo.Cities");
            DropIndex("dbo.Authors", new[] { "AuthorCityID" });
            AlterColumn("dbo.Authors", "AuthorCityID", c => c.Int(nullable: false));
            CreateIndex("dbo.Authors", "AuthorCityID");
            AddForeignKey("dbo.Cities", "CountryID", "dbo.Countries", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Authors", "AuthorCityID", "dbo.Cities", "ID", cascadeDelete: true);
        }
    }
}
