namespace AccPluss.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyClient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Address", c => c.String(nullable: false, maxLength: 50, storeType: "nvarchar"));
            AddColumn("dbo.Clients", "Birthdate", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.Clients", "Nit", c => c.String(nullable: false, maxLength: 15, storeType: "nvarchar"));
            AlterColumn("dbo.Clients", "Name", c => c.String(nullable: false, maxLength: 60, storeType: "nvarchar"));
            AlterColumn("dbo.Clients", "LastName", c => c.String(nullable: false, maxLength: 60, storeType: "nvarchar"));
            DropColumn("dbo.Clients", "DateCreated");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "DateCreated", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.Clients", "LastName", c => c.String(unicode: false));
            AlterColumn("dbo.Clients", "Name", c => c.String(unicode: false));
            AlterColumn("dbo.Clients", "Nit", c => c.String(unicode: false));
            DropColumn("dbo.Clients", "Birthdate");
            DropColumn("dbo.Clients", "Address");
        }
    }
}
