namespace tracklogger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNumberType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TrackPoints", "Lat", c => c.Single(nullable: false));
            AlterColumn("dbo.TrackPoints", "Lng", c => c.Single(nullable: false));
            AlterColumn("dbo.TrackPoints", "Elevation", c => c.Single(nullable: false));
            AlterColumn("dbo.TrackPoints", "Course", c => c.Single(nullable: false));
            AlterColumn("dbo.TrackPoints", "Speed", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TrackPoints", "Speed", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.TrackPoints", "Course", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.TrackPoints", "Elevation", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.TrackPoints", "Lng", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.TrackPoints", "Lat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
