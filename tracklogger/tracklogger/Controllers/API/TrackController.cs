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

        public HttpResponseMessage Get(decimal lat, decimal lng, decimal ele, decimal crs, decimal spd, int sat)
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
    }
}
