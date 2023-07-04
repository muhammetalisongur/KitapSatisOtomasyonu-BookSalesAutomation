namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBooknullabebooktranslator : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "BookTranslatorID", "dbo.BookTranslators");
            DropIndex("dbo.Books", new[] { "BookTranslatorID" });
            AlterColumn("dbo.Books", "BookTranslatorID", c => c.Int());
            CreateIndex("dbo.Books", "BookTranslatorID");
            AddForeignKey("dbo.Books", "BookTranslatorID", "dbo.BookTranslators", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "BookTranslatorID", "dbo.BookTranslators");
            DropIndex("dbo.Books", new[] { "BookTranslatorID" });
            AlterColumn("dbo.Books", "BookTranslatorID", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "BookTranslatorID");
            AddForeignKey("dbo.Books", "BookTranslatorID", "dbo.BookTranslators", "ID", cascadeDelete: true);
        }
    }
}
