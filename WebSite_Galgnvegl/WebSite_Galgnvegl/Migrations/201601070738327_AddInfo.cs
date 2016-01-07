namespace WebSite_Galgnvegl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Marketdatabases", "Promoter", c => c.String());
            AddColumn("dbo.Marketdatabases", "Info", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Marketdatabases", "Info");
            DropColumn("dbo.Marketdatabases", "Promoter");
        }
    }
}
