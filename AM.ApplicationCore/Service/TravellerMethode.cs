using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Service
{
    public class TravellerMethode : ITravellerMethode
    {
        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            var query = from t in flight.Passengers.OfType<Traveller>()
                         orderby t.BirthDate
                         select t;

            return query.Take(3);
        }
    }
}
