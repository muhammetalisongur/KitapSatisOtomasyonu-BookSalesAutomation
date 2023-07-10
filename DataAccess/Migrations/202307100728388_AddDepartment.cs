namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Employees", "AuthorImage", c => c.String());
            AddColumn("dbo.Employees", "DepartmentID", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "DepartmentID");
            AddForeignKey("dbo.Employees", "DepartmentID", "dbo.Departments", "ID", cascadeDelete: true);
            DropColumn("dbo.Employees", "Department");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Department", c => c.String());
            DropForeignKey("dbo.Employees", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DepartmentID" });
            DropColumn("dbo.Employees", "DepartmentID");
            DropColumn("dbo.Employees", "AuthorImage");
            DropTable("dbo.Departments");
        }
    }
}
