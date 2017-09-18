
namespace WebApi.BLL.Object
{
    public class Passenger
    {
        public string Name { get; set; }
        public int NumBags { get; set; }
        public int Seat { get; set; }

        public Passenger(string _Name, int _NumBags, int _Seat)
        {
            this.Name = _Name;
            this.NumBags = _NumBags;
            this.Seat = _Seat;
        }
    }
}
