using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace tracklogger.Models
{
    public class TrackPoint
    {
        public int TrackPointID { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public int Satellites { get; set; }
        public decimal Elevation { get; set; }
        public decimal Course { get; set; }
        public decimal Speed { get; set; }
        public DateTime Time { get; set; }
    }

    public class TrackPointsContext : DbContext
    {
        public DbSet<TrackPoint> TrackPoints { get; set; }
    }
}