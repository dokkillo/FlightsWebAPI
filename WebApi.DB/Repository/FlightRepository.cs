using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.BLL.Object;

namespace WebApi.DB.Repository
{
    public class FlightRepository
    {
        private DataBase db;

        public FlightRepository (DataBase _db)
        {
            this.db = _db;
        }

        public List<Flight> Load(string Origin, string Destination, int Passengers, DateTime DateIn)
        {
            return db.GetFlights().Where(x => x.Origin.ToLower() == Origin.ToLower() && x.Destintation.ToLower() == Destination.ToLower() && x.Time.Date == DateIn.Date).ToList();          
        }



    }
}
