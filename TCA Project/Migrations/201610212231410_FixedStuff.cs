namespace TCA_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedStuff : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        City = c.Int(nullable: false),
                        State = c.String(),
                        Zipcode = c.Single(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        DayID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.PickUpDays", t => t.DayID)
                .Index(t => t.CustomerID)
                .Index(t => t.DayID);
            
            CreateTable(
                "dbo.PickUpDays",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Day = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "DayID", "dbo.PickUpDays");
            DropForeignKey("dbo.Addresses", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Addresses", new[] { "DayID" });
            DropIndex("dbo.Addresses", new[] { "CustomerID" });
            DropTable("dbo.PickUpDays");
            DropTable("dbo.Addresses");
        }
    }
}
