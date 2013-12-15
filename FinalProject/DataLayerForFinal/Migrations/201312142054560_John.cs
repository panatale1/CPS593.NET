namespace DataLayerForFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class John : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AID = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZIP = c.String(),
                        Type = c.Int(nullable: false),
                        PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AID);
            
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        EID = c.Int(nullable: false, identity: true),
                        EmailAddress = c.String(),
                        Type = c.Int(nullable: false),
                        PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PID);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        PhID = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(),
                        Type = c.Int(nullable: false),
                        PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PhID);
            
            CreateTable(
                "dbo.CTypes",
                c => new
                    {
                        TID = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.TID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CTypes");
            DropTable("dbo.Phones");
            DropTable("dbo.People");
            DropTable("dbo.Emails");
            DropTable("dbo.Addresses");
        }
    }
}
