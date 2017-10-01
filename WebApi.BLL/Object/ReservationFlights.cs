using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.BLL.Object
{
    [DataContract]
    public class ReservationFlights { 

    [Required]
    [DataMember]
    public string FlightKey { get; set; }
    [Required]
    [DataMember]
    public List<Passenger> Passengers { get; set; }

        public ReservationFlights(string _FlightKey, List<Passenger> _Passengers)
        {
            this.FlightKey = _FlightKey;
            this.Passengers = _Passengers;
        }
    }
}
