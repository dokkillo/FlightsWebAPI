using System;
using System.Collections.Generic;
using WebApi.BLL.Object;

namespace WebApi.DB
{
    public class DataBase
    {
        private static List<Flight> FlightList;
        private static List<Reservation> Reservations;
        private static DataBase _instance;

        private DataBase()
        {
            Init();
        }

        public static DataBase Instance
        {
            get
            {
                return Nested.instance;
            }
        }


        private class Nested {

            static Nested()
            {

            }

            internal static readonly DataBase instance = new DataBase();

        }

        public List<Flight> GetFlights()
        {
            return FlightList;
        }

        public List<Reservation> GetReservation()
        {
            return Reservations;
        }


        private void Init()
        {
            FlightList = new List<Flight>()
            {
                new Flight("Flight0001","MADRID","DUBLIN",new DateTime(2017,8,1,18,20,0)),
                new Flight("Flight0002","DUBLIN","MADRID",new DateTime(2017,8,5,18,20,0)),
                new Flight("Flight0003","MADRID","IBIZA",new DateTime(2017,9,1,18,20,0)),
                new Flight("Flight0004","IBIZA","MADRID",new DateTime(2017,9,5,18,20,0))
            };

            Reservations = new List<Reservation>()
            {
               new Reservation("0001","test@test.com","00000", new List<ReservationFlights>()
               {
                            new ReservationFlights("Flight0001", new List<Passenger>()
                            {
                                new Passenger("Hermegildo Zelda",1,1)
                            }),
                            new ReservationFlights("Flight0002", new List<Passenger>()
                            {
                                new Passenger("Hermegildo Zelda",1,1)
                            }),

               })
            };
            
        }
    }
}
