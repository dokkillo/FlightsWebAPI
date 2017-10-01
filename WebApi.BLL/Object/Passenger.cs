
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace WebApi.BLL.Object
{
    [DataContract]
    public class Passenger
    {
        [Required]
        [DataMember]
        public string Name { get; set; }
        [Required]
        [DataMember]
        public int NumBags { get; set; }
        [Required]
        [DataMember]
        public int Seat { get; set; }

        public Passenger(string _Name, int _NumBags, int _Seat)
        {
            this.Name = _Name;
            this.NumBags = _NumBags;
            this.Seat = _Seat;
        }
    }
}
