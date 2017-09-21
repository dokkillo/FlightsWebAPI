using System;
using System.Runtime.Serialization;

namespace WebApi.BLL.Object
{
    [DataContract]
    public class Flight
    {
        [DataMember]
        public string Key { get; set; }

        [DataMember]
        public string Origin { get; set; }

        [DataMember]
        public string Destintation { get; set; }

        [DataMember]
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
