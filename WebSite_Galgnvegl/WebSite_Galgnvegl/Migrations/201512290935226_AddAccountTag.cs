namespace WebSite_Galgnvegl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAccountTag : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Marketdatabases", "AccountTag", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Marketdatabases", "AccountTag");
        }
    }
}
