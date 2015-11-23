namespace WebSite_Galgnvegl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MArketURL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Marketdatabases", "URL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Marketdatabases", "URL");
        }
    }
}
