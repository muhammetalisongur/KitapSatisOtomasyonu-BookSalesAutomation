namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AuthorImageConvertImageByte : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "AuthorImage", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Authors", "AuthorImage", c => c.String(nullable: false, maxLength: 250));
        }
    }
}
