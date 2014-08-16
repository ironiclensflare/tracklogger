using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using tracklogger.Models;

namespace tracklogger.Controllers.API
{
    public class TrackController : ApiController
    {
        private TrackPointsContext tc = new TrackPointsContext();

        public HttpResponseMessage Get(float lat, float lng, float ele, float crs, float spd, int sat)
        {
            TrackPoint t = new TrackPoint();
            t.Lat = lat;
            t.Lng = lng;
            t.Satellites = sat;
            t.Elevation = ele;
            t.Course = crs;
            t.Speed = spd;
            t.Time = DateTime.Now;

            tc.TrackPoints.Add(t);
            tc.SaveChanges();
            
            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        public IQueryable<TrackPoint> Get()
        {
            DateTime today = DateTime.Now.Date;
            return tc.TrackPoints
                .Where(t => t.Time >= today)
                .OrderByDescending(t => t.TrackPointID);
        }
    }
}
