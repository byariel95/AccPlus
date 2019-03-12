namespace AccPluss.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatefirtsEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nit = c.String(unicode: false),
                        Name = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        Active = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}
