namespace DataLayerForFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fixing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "Person_PID", c => c.Int());
            AddColumn("dbo.Emails", "Person_PID", c => c.Int());
            AddColumn("dbo.Phones", "Person_PID", c => c.Int());
            CreateIndex("dbo.Addresses", "Person_PID");
            CreateIndex("dbo.Emails", "Person_PID");
            CreateIndex("dbo.Phones", "Person_PID");
            AddForeignKey("dbo.Addresses", "Person_PID", "dbo.People", "PID");
            AddForeignKey("dbo.Emails", "Person_PID", "dbo.People", "PID");
            AddForeignKey("dbo.Phones", "Person_PID", "dbo.People", "PID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "Person_PID", "dbo.People");
            DropForeignKey("dbo.Emails", "Person_PID", "dbo.People");
            DropForeignKey("dbo.Addresses", "Person_PID", "dbo.People");
            DropIndex("dbo.Phones", new[] { "Person_PID" });
            DropIndex("dbo.Emails", new[] { "Person_PID" });
            DropIndex("dbo.Addresses", new[] { "Person_PID" });
            DropColumn("dbo.Phones", "Person_PID");
            DropColumn("dbo.Emails", "Person_PID");
            DropColumn("dbo.Addresses", "Person_PID");
        }
    }
}
