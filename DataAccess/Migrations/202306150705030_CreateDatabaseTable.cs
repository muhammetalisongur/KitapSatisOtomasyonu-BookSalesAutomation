namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabaseTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(nullable: false, maxLength: 50),
                        AuthorSurname = c.String(nullable: false, maxLength: 50),
                        AuthorBiography = c.String(nullable: false),
                        AuthorImage = c.String(nullable: false, maxLength: 250),
                        AuthorCountry = c.String(nullable: false),
                        AuthorCity = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BookName = c.String(nullable: false, maxLength: 50),
                        BookDescription = c.String(nullable: false),
                        BookImage = c.String(nullable: false, maxLength: 250),
                        BookPublisherID = c.Int(nullable: false),
                        BookAuthorID = c.Int(nullable: false),
                        BookCategoryID = c.Int(nullable: false),
                        BookLanguage = c.String(nullable: false, maxLength: 50),
                        BookTranslatorID = c.Int(nullable: false),
                        BookPage = c.Int(nullable: false),
                        BookPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BookISBN = c.String(nullable: false, maxLength: 20),
                        BookStock = c.Int(nullable: false),
                        BookPublishDate = c.Int(nullable: false),
                        BookStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Authors", t => t.BookAuthorID, cascadeDelete: true)
                .ForeignKey("dbo.BookTranslators", t => t.BookTranslatorID, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.BookCategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Publishers", t => t.BookPublisherID, cascadeDelete: true)
                .Index(t => t.BookPublisherID)
                .Index(t => t.BookAuthorID)
                .Index(t => t.BookCategoryID)
                .Index(t => t.BookTranslatorID);
            
            CreateTable(
                "dbo.BookTranslators",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TranslatorName = c.String(nullable: false, maxLength: 50),
                        TranslatorSurname = c.String(nullable: false, maxLength: 50),
                        TranslatorBiography = c.String(nullable: false),
                        TranslatorImage = c.String(nullable: false, maxLength: 250),
                        TranslatorCountry = c.String(nullable: false),
                        TranslatorCity = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PublisherName = c.String(nullable: false, maxLength: 50),
                        PublisherDescription = c.String(nullable: false),
                        PublisherAddress = c.String(nullable: false, maxLength: 250),
                        PublisherEmail = c.String(nullable: false, maxLength: 50),
                        PublisherImage = c.String(nullable: false, maxLength: 250),
                        PublisherCountry = c.String(nullable: false),
                        PublisherCity = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "BookPublisherID", "dbo.Publishers");
            DropForeignKey("dbo.Books", "BookCategoryID", "dbo.Categories");
            DropForeignKey("dbo.Books", "BookTranslatorID", "dbo.BookTranslators");
            DropForeignKey("dbo.Books", "BookAuthorID", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "BookTranslatorID" });
            DropIndex("dbo.Books", new[] { "BookCategoryID" });
            DropIndex("dbo.Books", new[] { "BookAuthorID" });
            DropIndex("dbo.Books", new[] { "BookPublisherID" });
            DropTable("dbo.Publishers");
            DropTable("dbo.Categories");
            DropTable("dbo.BookTranslators");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
