namespace TCA_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class configuringUsers : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Addresses", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Addresses", new[] { "CustomerID" });
            AddColumn("dbo.Addresses", "UserID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Addresses", "UserID");
            AddForeignKey("dbo.Addresses", "UserID", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Addresses", "CustomerID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addresses", "CustomerID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Addresses", "UserID", "dbo.AspNetUsers");
            DropIndex("dbo.Addresses", new[] { "UserID" });
            DropColumn("dbo.Addresses", "UserID");
            CreateIndex("dbo.Addresses", "CustomerID");
            AddForeignKey("dbo.Addresses", "CustomerID", "dbo.Customers", "ID", cascadeDelete: true);
        }
    }
}
