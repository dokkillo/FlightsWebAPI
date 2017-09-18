using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.BLL.Object;
using WebApi.DB;
using WebApi.DB.Repository;

namespace WebApi.BML
{
    public class FlightSearch
    {
        private DataBase db;

        public FlightSearch(DataBase _db)
        {
            this.db = _db;
        }

        public List<Flight> Search(string Origin, string Destination, int Passengers, DateTime DateIn, DateTime DateOut, bool Roundtrip)
        {
            var repository = new FlightRepository(db);
            return repository.Load(Origin, Destination, Passengers, DateIn);
        }
    }
}
