namespace DataLayerForFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fixing2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "Type", c => c.String());
            AlterColumn("dbo.Emails", "Type", c => c.String());
            AlterColumn("dbo.People", "Type", c => c.String());
            AlterColumn("dbo.Phones", "Type", c => c.String());
            AlterColumn("dbo.CTypes", "TypeName", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.CTypes");
            AddPrimaryKey("dbo.CTypes", "TypeName");
            DropColumn("dbo.CTypes", "TID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CTypes", "TID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.CTypes");
            AddPrimaryKey("dbo.CTypes", "TID");
            AlterColumn("dbo.CTypes", "TypeName", c => c.String());
            AlterColumn("dbo.Phones", "Type", c => c.Int(nullable: false));
            AlterColumn("dbo.People", "Type", c => c.Int(nullable: false));
            AlterColumn("dbo.Emails", "Type", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "Type", c => c.Int(nullable: false));
        }
    }
}
