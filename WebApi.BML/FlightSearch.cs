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
    public class FlightSearch
    {
        private DataBase db;
        const int MAX_PLACES = 50;

        public FlightSearch(DataBase _db)
        {
            this.db = _db;
        }

        public List<Flight> Search(string Origin, string Destination, int Passengers, DateTime DateIn, DateTime DateOut, bool Roundtrip)
        {
            var flights = GetFlight(Origin, Destination, Passengers, DateIn);

            if(Roundtrip)
            {
                flights.AddRange(GetFlight(Destination, Origin, Passengers, DateOut));
            }

            return flights;
        }

        private List<Flight> GetFlight(string Origin, string Destination, int Passengers, DateTime DateIn)
        {
            var AvailableFlightList = new List<Flight>();
            var repository = new FlightRepository(db);
            var flights = repository.Load(Origin, Destination, DateIn);
            foreach (var flight in flights)
            {
                if (ExistAvailableSeats(flight.Key, Passengers))
                {
                    AvailableFlightList.Add(flight);
                }
            }

            return AvailableFlightList;
        }

        private bool ExistAvailableSeats(string FlightKey, int Passangers)
        {
            var repository = new ReservationRepository(db);
            if(repository.GetNumReservations(FlightKey) <= MAX_PLACES + Passangers)
            {
                return true;
            }
            return false;
        }
    }
}
