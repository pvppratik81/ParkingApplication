namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(),
                        MiddleName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        RoleId = c.Int(nullable: false),
                        ParkingSlotId = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ParkingSlots", t => t.ParkingSlotId)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.ParkingSlotId);
            
            CreateTable(
                "dbo.ParkingSlots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SlotName = c.String(nullable: false),
                        IsAssigned = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReleasedSlots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParkingSlotId = c.Int(),
                        ReleasedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ParkingSlots", t => t.ParkingSlotId)
                .Index(t => t.ParkingSlotId);
            
            CreateTable(
                "dbo.RequestSlots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(),
                        RequestDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.SlotAllocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(),
                        ParkingSlotId = c.Int(),
                        AllocationDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .ForeignKey("dbo.ParkingSlots", t => t.ParkingSlotId)
                .Index(t => t.EmployeeId)
                .Index(t => t.ParkingSlotId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SlotAllocations", "ParkingSlotId", "dbo.ParkingSlots");
            DropForeignKey("dbo.SlotAllocations", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.RequestSlots", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.ReleasedSlots", "ParkingSlotId", "dbo.ParkingSlots");
            DropForeignKey("dbo.Employees", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Employees", "ParkingSlotId", "dbo.ParkingSlots");
            DropIndex("dbo.SlotAllocations", new[] { "ParkingSlotId" });
            DropIndex("dbo.SlotAllocations", new[] { "EmployeeId" });
            DropIndex("dbo.RequestSlots", new[] { "EmployeeId" });
            DropIndex("dbo.ReleasedSlots", new[] { "ParkingSlotId" });
            DropIndex("dbo.Employees", new[] { "ParkingSlotId" });
            DropIndex("dbo.Employees", new[] { "RoleId" });
            DropTable("dbo.SlotAllocations");
            DropTable("dbo.RequestSlots");
            DropTable("dbo.ReleasedSlots");
            DropTable("dbo.Roles");
            DropTable("dbo.ParkingSlots");
            DropTable("dbo.Employees");
        }
    }
}
