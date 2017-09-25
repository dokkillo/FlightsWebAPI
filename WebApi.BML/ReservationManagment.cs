using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.BLL.Object;
using WebApi.DB;
using WebApi.DB.Repository;

namespace WebApi.BML
{
    public class ReservationManagment
    {
        private DataBase db;
        const int MAX_PLACES = 50;
        private ReservationRepository repo;

        public ReservationManagment(DataBase _db)
        {
            this.db = _db;
            repo = new ReservationRepository(db);
        }

        public List<Reservation> GetReservations()
        {
            return repo.GetReservations();
        }

        public Reservation GetReservation(string ReservationKey)
        {
            return repo.GetReservation(ReservationKey);
        }

        public string SaveReservation(Reservation NewReservation)
        {          

            string newReservationKey = repo.NextReservationNumber().ToString().PadLeft(4,'0');
            NewReservation.ReservationNumber = newReservationKey;
            repo.Save(NewReservation);
            return newReservationKey;

        }
    }
}
