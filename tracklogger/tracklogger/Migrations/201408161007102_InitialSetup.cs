namespace tracklogger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrackPoints",
                c => new
                    {
                        TrackPointID = c.Int(nullable: false, identity: true),
                        Lat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Lng = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Satellites = c.Int(nullable: false),
                        Elevation = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Course = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Speed = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TrackPointID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TrackPoints");
        }
    }
}
