
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.BLL.Object
{
    public class Reservation
    {

        public string ReservationNumber { get; set; }
        [Required][EmailAddress]
        public string Email { get; set; }
        [Required]
        public string CreditCard { get; set; }
        [Required]
        public List<ReservationFlights> Flights { get; set; }

        public Reservation(string _ReservationNumber, string _Email, string _CreditCard, List<ReservationFlights> _Flights)
        {
            this.ReservationNumber = _ReservationNumber;
            this.Email = _Email;
            this.CreditCard = _CreditCard;
            this.Flights = _Flights;
        }

    }
}
