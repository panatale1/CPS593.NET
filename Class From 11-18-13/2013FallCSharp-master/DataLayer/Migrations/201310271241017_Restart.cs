namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Restart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StreetAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        ContactId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contacts", t => t.ContactId, cascadeDelete: true)
                .Index(t => t.ContactId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        KeywordId = c.Int(nullable: false),
                        fbid = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Keywords", t => t.KeywordId, cascadeDelete: false)
                .Index(t => t.KeywordId);
            
            CreateTable(
                "dbo.ContactMethods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                        ContactId = c.Int(nullable: false),
                        KeywordId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contacts", t => t.ContactId, cascadeDelete: true)
                .ForeignKey("dbo.Keywords", t => t.KeywordId, cascadeDelete: false)
                .Index(t => t.ContactId)
                .Index(t => t.KeywordId);
            
            CreateTable(
                "dbo.Keywords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ParentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Keywords", t => t.ParentId, cascadeDelete: false)
                .Index(t => t.ParentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contacts", "KeywordId", "dbo.Keywords");
            DropForeignKey("dbo.ContactMethods", "KeywordId", "dbo.Keywords");
            DropForeignKey("dbo.Keywords", "ParentId", "dbo.Keywords");
            DropForeignKey("dbo.ContactMethods", "ContactId", "dbo.Contacts");
            DropForeignKey("dbo.Addresses", "ContactId", "dbo.Contacts");
            DropIndex("dbo.Contacts", new[] { "KeywordId" });
            DropIndex("dbo.ContactMethods", new[] { "KeywordId" });
            DropIndex("dbo.Keywords", new[] { "ParentId" });
            DropIndex("dbo.ContactMethods", new[] { "ContactId" });
            DropIndex("dbo.Addresses", new[] { "ContactId" });
            DropTable("dbo.Keywords");
            DropTable("dbo.ContactMethods");
            DropTable("dbo.Contacts");
            DropTable("dbo.Addresses");
        }
    }
}
