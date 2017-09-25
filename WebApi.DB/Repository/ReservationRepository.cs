using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.BLL.Object;

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

        public int NextReservationNumber()
        {
            return db.GetReservation().Select(x => Convert.ToInt32(x.ReservationNumber)).Max() + 1;
        }

        public Reservation GetReservation(string ReservationKey)
        {
            var reservation = db.GetReservation().Where(x => x.ReservationNumber == ReservationKey).FirstOrDefault();
            return reservation;
        }

        public List<Reservation> GetReservations()
        {
            return db.GetReservation();
        }


        public void Save(Reservation NewReservation)
        {
            db.GetReservation().Add(NewReservation);
        }

    }
}
