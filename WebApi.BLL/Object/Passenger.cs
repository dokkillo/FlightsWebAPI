
using System.ComponentModel.DataAnnotations;

namespace WebApi.BLL.Object
{
    public class Passenger
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int NumBags { get; set; }
        [Required]
        public int Seat { get; set; }

        public Passenger(string _Name, int _NumBags, int _Seat)
        {
            this.Name = _Name;
            this.NumBags = _NumBags;
            this.Seat = _Seat;
        }
    }
}
