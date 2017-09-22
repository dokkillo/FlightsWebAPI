using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.BLL.Object;
using WebApi.DB;

namespace WebApi.BML
{
    public class ReservationManagment
    {
        private DataBase db;
        const int MAX_PLACES = 50;

        public ReservationManagment(DataBase _db)
        {
            this.db = _db;
        }

        public List<Reservation> GetReservations()
        {
            return db.GetReservation();
        }

        public Reservation GetReservation(string ReservationKey)
        {
            var reservation= db.GetReservation().Where(x=> x.ReservationNumber == ReservationKey).FirstOrDefault();
            return reservation;
        }
    }
}
