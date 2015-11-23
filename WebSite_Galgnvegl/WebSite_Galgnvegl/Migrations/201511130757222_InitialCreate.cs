namespace WebSite_Galgnvegl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Marketdatabases",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date_from = c.DateTime(nullable: false),
                        Date_to = c.DateTime(nullable: false),
                        Marketname = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Marketdatabases");
        }
    }
}
