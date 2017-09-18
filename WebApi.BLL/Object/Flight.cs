using System;

namespace WebApi.BLL.Object
{
    public class Flight
    {
        public string Key { get; set; }
        public string Origin { get; set; }
        public string Destintation { get; set; }
        public DateTime Time { get; set; }

        public Flight(string _Key, string _Origin, string _Destination, DateTime _Time)
        {
            this.Key = _Key;
            this.Origin = _Origin;
            this.Destintation = _Destination;
            this.Time = _Time;
        }

    }
}
