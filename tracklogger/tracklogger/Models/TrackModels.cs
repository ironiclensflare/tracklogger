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
        public float Lat { get; set; }
        public float Lng { get; set; }
        public int Satellites { get; set; }
        public float Elevation { get; set; }
        public float Course { get; set; }
        public float Speed { get; set; }
        public DateTime Time { get; set; }
    }

    public class TrackPointsContext : DbContext
    {
        public DbSet<TrackPoint> TrackPoints { get; set; }
    }
}