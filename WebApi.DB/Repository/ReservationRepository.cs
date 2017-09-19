using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.DB.Repository
{
    public class ReservationRepository
    {
        private DataBase db;

        public ReservationRepository(DataBase _db)
        {
            this.db = _db;
        }

        public int GetNumReservations(string FlightKey)
        {
            return db.GetReservation().SelectMany(x => x.Flights).Where(y => y.FlightKey == FlightKey).Count();
        }
    }
}
