namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Catchup : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Keywords", "Id", c => c.Int(nullable: false, identity: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Keywords", "Id", c => c.Int(nullable: false));
        }
    }
}
