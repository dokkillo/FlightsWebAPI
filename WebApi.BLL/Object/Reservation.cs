
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace WebApi.BLL.Object
{
    [DataContract]
    public class Reservation
    {

        [DataMember]
        public string ReservationNumber { get; set; }
        [Required][EmailAddress][DataMember]
        public string Email { get; set; }
        [Required][DataMember]
        public string CreditCard { get; set; }
        [Required][DataMember]
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
