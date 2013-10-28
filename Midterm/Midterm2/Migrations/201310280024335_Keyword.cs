namespace Midterm2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Keyword : DbMigration
    {
        public override void Up()
        {
           /* CreateTable(
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
                        KeywordsId = c.Int(nullable: false),
                        fbid = c.String(maxLength: 500),
                        Keyword_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Keywords", t => t.Keyword_Id)
                .Index(t => t.Keyword_Id);
            
            CreateTable(
                "dbo.ContactMethods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                        ContactsId = c.Int(nullable: false),
                        KeywordId = c.Int(nullable: false),
                        Contact_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contacts", t => t.Contact_Id)
                .ForeignKey("dbo.Keywords", t => t.KeywordId, cascadeDelete: true)
                .Index(t => t.Contact_Id)
                .Index(t => t.KeywordId);
            
            CreateTable(
                "dbo.Keywords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        KeywordsId = c.Int(nullable: false),
                        Parent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Keywords", t => t.Parent_Id)
                .Index(t => t.Parent_Id);
            
            CreateTable(
                "dbo.ContactMethods1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Contacts_Id = c.Int(nullable: false),
                        Keywords_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contacts1", t => t.Contacts_Id, cascadeDelete: true)
                .ForeignKey("dbo.Keywords1", t => t.Keywords_Id, cascadeDelete: true)
                .Index(t => t.Contacts_Id)
                .Index(t => t.Keywords_Id);
            
            CreateTable(
                "dbo.Contacts1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Keyword_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Keywords1", t => t.Keyword_Id, cascadeDelete: true)
                .Index(t => t.Keyword_Id);
            
            CreateTable(
                "dbo.Keywords1",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Parent_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Keywords1", t => t.Parent_Id)
                .Index(t => t.Parent_Id);
            * */
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "ContactId", "dbo.Contacts");
            DropForeignKey("dbo.Contacts", "Keyword_Id", "dbo.Keywords");
            DropForeignKey("dbo.ContactMethods", "KeywordId", "dbo.Keywords");
            DropForeignKey("dbo.Keywords", "Parent_Id", "dbo.Keywords");
            DropForeignKey("dbo.ContactMethods", "Contact_Id", "dbo.Contacts");
            DropIndex("dbo.Addresses", new[] { "ContactId" });
            DropIndex("dbo.Contacts", new[] { "Keyword_Id" });
            DropIndex("dbo.ContactMethods", new[] { "KeywordId" });
            DropIndex("dbo.Keywords", new[] { "Parent_Id" });
            DropIndex("dbo.ContactMethods", new[] { "Contact_Id" });
            DropTable("dbo.Keywords");
            DropTable("dbo.ContactMethods");
            DropTable("dbo.Contacts");
            DropTable("dbo.Addresses");
        }
    }
}
