using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApi.BML;
using WebApi.DB;

namespace WebApi.Controllers
{
    public class FlightController : ApiController
    {

        public IHttpActionResult Get()
        {
            int passengers;
            string origin;
            string destination;
            DateTime dateIn;
            DateTime dateOut;
            bool roundtrip;
            var db = DataBase.Instance;
            var flightSearch = new FlightSearch(db);
            NameValueCollection queryString = HttpUtility.ParseQueryString(Request.RequestUri.Query);

            if(queryString.Get("passengers") == null || queryString.Get("origin") == null  ||
                queryString.Get("destination") == null || queryString.Get("dateIn") == null ||
                queryString.Get("roundTrip") == null)
            {
                return BadRequest();
            }
            



            if(!Int32.TryParse(queryString.Get("passengers"),out passengers))
            {
                return BadRequest("passengers must be a number");
            }
            if(passengers < 0)
            {
                return BadRequest("passengers must be one or more");
            }

            if(!DateTime.TryParse(queryString.Get("dateIn"),out dateIn))
            {
                return BadRequest("dateIn must be a date");
            }

            if(!Boolean.TryParse(queryString.Get("roundTrip"),out roundtrip))
            {
                return BadRequest("Roundtrip parameter is not set to true or false");
            }
          
            //DateOut parameter is optional, only is required if roundtrip is true.
            if(roundtrip)
            {
                if(queryString.Get("dateOut") == null)
                {
                    return BadRequest();
                }

                if (!DateTime.TryParse(queryString.Get("dateOut"), out dateOut))
                {
                    return BadRequest("dateOut must be a date");
                }

            }

            origin = queryString.Get("origin");
            destination = queryString.Get("destination");

            var result = flightSearch.Search(origin, destination, passengers, dateIn, DateTime.MinValue, false);
            


            return Ok(result);
        }


        public IHttpActionResult Post()
        {

            return Ok();
        }


        }
}
