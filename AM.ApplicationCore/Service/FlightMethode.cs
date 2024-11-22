using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Service
{
    public class FlightMethode : IFlightMethode
    {
        IList<Flight> flights = new List<Flight>();

        public IList<DateTime> GetFlightDates(string destination)
        {
            var query = from f in flights
                        where f.Destination == destination
                        select f.FlightDate;

            return query.ToList();
        }

        public void ShowFlightDetails(Plane plane)
        {
            var query = from f in plane.Flights
                        select new { f.Destination, f.FlightDate };

            foreach (var flight in query)
            {
                Console.WriteLine("Destination: " + flight.Destination + " Date: " + flight.FlightDate);
            }
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            DateTime endDate = startDate.AddDays(7);

            var query = from f in flights
                        where f.FlightDate >= startDate && f.FlightDate < endDate
                        select f;

            return query.Count();
        }

        public double DurationAverage(string destination)
        {
            var query = from f in flights
                        where f.Destination == destination
                        select f.EstimatedDuration;

            return query.Average();
        }

        public IEnumerable<Flight> OrderedDurationFlights()
        {
            var query = from f in flights
                        orderby f.EstimatedDuration descending
                        select f;

            return query;
        }

        public void DestinationGroupedFlights()
        {
            var query = from f in flights
                        group f by f.Destination into groupedFlights
                        orderby groupedFlights.Key
                        select groupedFlights;

            foreach (var group in query)
            {
                Console.WriteLine($"Destination {group.Key}");
                foreach (var flight in group.OrderBy(f => f.FlightDate))
                {
                    Console.WriteLine($"Décollage : {flight.FlightDate:dd/MM/yyyy HH:mm:ss}");
                }
            }
        }
    }
}
