using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.BLL.Object
{
    public class ReservationFlights { 

    [Required]
     public string FlightKey { get; set; }
    [Required]
    public List<Passenger> Passengers { get; set; }

        public ReservationFlights(string _FlightKey, List<Passenger> _Passengers)
        {
            this.FlightKey = _FlightKey;
            this.Passengers = _Passengers;
        }
    }
}
