namespace DataLayerForFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fixing4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Emails", "type_TypeName", "dbo.CTypes");
            DropForeignKey("dbo.Phones", "type_TypeName", "dbo.CTypes");
            DropForeignKey("dbo.Addresses", "type_TypeName", "dbo.CTypes");
            DropForeignKey("dbo.Addresses", "person_PID", "dbo.People");
            DropForeignKey("dbo.Emails", "person_PID", "dbo.People");
            DropIndex("dbo.Emails", new[] { "type_TypeName" });
            DropIndex("dbo.Phones", new[] { "type_TypeName" });
            DropIndex("dbo.Addresses", new[] { "type_TypeName" });
            DropIndex("dbo.Addresses", new[] { "person_PID" });
            DropIndex("dbo.Emails", new[] { "person_PID" });
            AlterColumn("dbo.Addresses", "Person_PID", c => c.Int());
            AlterColumn("dbo.Emails", "Person_PID", c => c.Int());
            CreateIndex("dbo.Addresses", "Person_PID");
            CreateIndex("dbo.Emails", "Person_PID");
            AddForeignKey("dbo.Addresses", "Person_PID", "dbo.People", "PID");
            AddForeignKey("dbo.Emails", "Person_PID", "dbo.People", "PID");
            DropColumn("dbo.Addresses", "type_TypeName");
            DropColumn("dbo.Emails", "type_TypeName");
            DropColumn("dbo.Phones", "type_TypeName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Phones", "type_TypeName", c => c.String(maxLength: 128));
            AddColumn("dbo.Emails", "type_TypeName", c => c.String(maxLength: 128));
            AddColumn("dbo.Addresses", "type_TypeName", c => c.String(maxLength: 128));
            DropForeignKey("dbo.Emails", "Person_PID", "dbo.People");
            DropForeignKey("dbo.Addresses", "Person_PID", "dbo.People");
            DropIndex("dbo.Emails", new[] { "Person_PID" });
            DropIndex("dbo.Addresses", new[] { "Person_PID" });
            AlterColumn("dbo.Emails", "Person_PID", c => c.Int());
            AlterColumn("dbo.Addresses", "Person_PID", c => c.Int());
            CreateIndex("dbo.Emails", "person_PID");
            CreateIndex("dbo.Addresses", "person_PID");
            CreateIndex("dbo.Addresses", "type_TypeName");
            CreateIndex("dbo.Phones", "type_TypeName");
            CreateIndex("dbo.Emails", "type_TypeName");
            AddForeignKey("dbo.Emails", "person_PID", "dbo.People", "PID");
            AddForeignKey("dbo.Addresses", "person_PID", "dbo.People", "PID");
            AddForeignKey("dbo.Addresses", "type_TypeName", "dbo.CTypes", "TypeName");
            AddForeignKey("dbo.Phones", "type_TypeName", "dbo.CTypes", "TypeName");
            AddForeignKey("dbo.Emails", "type_TypeName", "dbo.CTypes", "TypeName");
        }
    }
}
