namespace AccPluss.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nit = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        Name = c.String(nullable: false, maxLength: 60, storeType: "nvarchar"),
                        LastName = c.String(nullable: false, maxLength: 60, storeType: "nvarchar"),
                        Address = c.String(maxLength: 50, storeType: "nvarchar"),
                        Active = c.Boolean(nullable: false),
                        Birthdate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NoDocument = c.String(nullable: false, maxLength: 30, storeType: "nvarchar"),
                        Date = c.DateTime(nullable: false, precision: 0),
                        TypeDocument = c.String(maxLength: 30, storeType: "nvarchar"),
                        Import = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NetPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iva = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Client_Id = c.Int(nullable: false),
                        Provider_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .ForeignKey("dbo.Providers", t => t.Provider_Id, cascadeDelete: true)
                .Index(t => t.Client_Id)
                .Index(t => t.Provider_Id);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nit = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        Name = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "Provider_Id", "dbo.Providers");
            DropForeignKey("dbo.Purchases", "Client_Id", "dbo.Clients");
            DropIndex("dbo.Purchases", new[] { "Provider_Id" });
            DropIndex("dbo.Purchases", new[] { "Client_Id" });
            DropTable("dbo.Providers");
            DropTable("dbo.Purchases");
            DropTable("dbo.Clients");
        }
    }
}
