namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBookTranslatorCountryandCity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookTranslators", "TranslatorCountryID", c => c.Int(nullable: false));
            AddColumn("dbo.BookTranslators", "TranslatorCityID", c => c.Int());
            AlterColumn("dbo.BookTranslators", "TranslatorImage", c => c.String());
            CreateIndex("dbo.BookTranslators", "TranslatorCountryID");
            CreateIndex("dbo.BookTranslators", "TranslatorCityID");
            AddForeignKey("dbo.BookTranslators", "TranslatorCityID", "dbo.Cities", "ID");
            AddForeignKey("dbo.BookTranslators", "TranslatorCountryID", "dbo.Countries", "ID");
            DropColumn("dbo.BookTranslators", "TranslatorCountry");
            DropColumn("dbo.BookTranslators", "TranslatorCity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookTranslators", "TranslatorCity", c => c.String(nullable: false));
            AddColumn("dbo.BookTranslators", "TranslatorCountry", c => c.String(nullable: false));
            DropForeignKey("dbo.BookTranslators", "TranslatorCountryID", "dbo.Countries");
            DropForeignKey("dbo.BookTranslators", "TranslatorCityID", "dbo.Cities");
            DropIndex("dbo.BookTranslators", new[] { "TranslatorCityID" });
            DropIndex("dbo.BookTranslators", new[] { "TranslatorCountryID" });
            AlterColumn("dbo.BookTranslators", "TranslatorImage", c => c.String(nullable: false, maxLength: 250));
            DropColumn("dbo.BookTranslators", "TranslatorCityID");
            DropColumn("dbo.BookTranslators", "TranslatorCountryID");
        }
    }
}
