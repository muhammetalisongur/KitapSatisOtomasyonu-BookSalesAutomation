namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmployeeImage", c => c.String());
            DropColumn("dbo.Employees", "AuthorImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "AuthorImage", c => c.String());
            DropColumn("dbo.Employees", "EmployeeImage");
        }
    }
}
