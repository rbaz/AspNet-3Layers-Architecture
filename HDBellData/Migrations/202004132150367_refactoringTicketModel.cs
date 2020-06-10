namespace HDBellData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refactoringTicketModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ticket", "TDescription", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Ticket", "ProjectName", c => c.String(nullable: false));
            CreateIndex("dbo.Ticket", "EmployeeId");
            AddForeignKey("dbo.Ticket", "EmployeeId", "dbo.Employee", "EmployeeId", cascadeDelete: true);
            DropColumn("dbo.Ticket", "DepartmentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ticket", "DepartmentId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Ticket", "EmployeeId", "dbo.Employee");
            DropIndex("dbo.Ticket", new[] { "EmployeeId" });
            AlterColumn("dbo.Ticket", "ProjectName", c => c.String());
            AlterColumn("dbo.Ticket", "TDescription", c => c.String());
        }
    }
}
