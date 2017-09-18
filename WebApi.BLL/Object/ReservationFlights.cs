using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.BLL.Object
{
    public class ReservationFlights
    {
        public string FlightKey { get; set; }
        public List<Passenger> Passengers { get; set; }

        public ReservationFlights(string _FlightKey, List<Passenger> _Passengers)
        {
            this.FlightKey = _FlightKey;
            this.Passengers = _Passengers;
        }
    }
}
