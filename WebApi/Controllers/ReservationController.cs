using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApi.BLL.Object;
using WebApi.BML;
using WebApi.DB;

namespace WebApi.Controllers
{
    public class ReservationController : ApiController
    {
        public IHttpActionResult Get()
        {
            var db = DataBase.Instance;
            var managment = new ReservationManagment(db);

            return Ok(managment.GetReservations());

        }

        public IHttpActionResult Get(string id)
        {
            var db = DataBase.Instance;
            var managment = new ReservationManagment(db);
            var reservation = managment.GetReservation(id);

            if(reservation == null)
            {
                return NotFound();
            }
            return Ok(reservation);           

        }


        public IHttpActionResult Post(Reservation reservation)
        {
            var db = DataBase.Instance;
            var managment = new ReservationManagment(db);

            if (ModelState.IsValid)
            {
                return Ok(managment.SaveReservation(reservation));
            }

            return BadRequest();
           
        }

    }
}
