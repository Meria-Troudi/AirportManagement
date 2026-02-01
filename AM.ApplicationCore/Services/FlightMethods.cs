using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; }
            = new List<Flight> { };

        public Action<Plane> FlightDetailsDel;
        public Func<string, double> DurationAverageDel;

        public FlightMethods()
        {
            FlightDetailsDel = p=> 
            {
                var req = from f in Flights
                          where f.MyPlane == p
                          select f;
                foreach (var f in req)
                {
                    Console.WriteLine("Destination: " + f.Destination
                        + " Date: " + f.FlightDate);
                }

            };
            DurationAverageDel = d=> 
            {
                var req = from f in Flights
                          where f.Destination == d
                          select f.EstimatedDuration;

                return req.Average();

            };

        }

        public List<IGrouping<string, Flight>> DestinationGroupedFlights()
        {
            //var req = from f in Flights
            //          group f by f.Destination;

            //return req.ToList();
            return Flights
                .GroupBy(f => f.Destination)
                .ToList();
        }

        public double DurationAverage(string destination)
        {
            //var req= from f in Flights
            //         where f.Destination == destination
            //         select f.EstimatedDuration;

            //return req.Average();
            return Flights
                .Where(f=>f.Destination == destination)
                .Select(f => f.EstimatedDuration)
                .Average();
        }

        public List<DateTime> GetFlightDates(string destination)
        {
            //var req = from f in Flights
            //          where f.Destination == destination
            //          select f.FlightDate;

            //return req.ToList();

            var reqLambda = Flights
                .Where(f => f.Destination == destination)
                .Select(f => f.FlightDate);

            return reqLambda.ToList();



            //List<DateTime> result = new List<DateTime>();

                          ////for (int i = 0; i < Flights.Count; i++)
                          ////{ 
                          ////    if (Flights[i].Destination == destination)
                          ////        result.Add(Flights[i].FlightDate);
                          ////} 
                          //foreach (var flight in Flights)
                          //{
                          //    if (flight.Destination == destination)
                          //    {
                          //        result.Add(flight.FlightDate);
                          //    }
                          //}
                          //return result;
                          //

        }

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (var flight in Flights)
                    {
                        if (flight.Destination == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "EstimatedDuration":
                    foreach (var flight in Flights)
                    {
                        if (flight.EstimatedDuration == int.Parse(filterValue))
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (var flight in Flights)
                    {
                        if (flight.FlightDate == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
            }
        }

        public List<Flight> OrderedDurationFlights()
        {
            //var req = from f in Flights
            //          orderby f.EstimatedDuration descending
            //          select f;
            //return req.ToList();
            return Flights
                .OrderByDescending(f => f.EstimatedDuration)
                .ToList();

        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            //var req= from f in Flights
            //         where f.FlightDate>=startDate
            //         && f.FlightDate<startDate.AddDays(7)
            //         select f;

            //return req.Count();
            return Flights
                .Where(f => f.FlightDate >= startDate
                   && f.FlightDate < startDate.AddDays(7))
                .Count();
        }
        public List<Traveller> SeniorTraveller(Flight flight)
        {
            var req = from p in flight.Passengers.OfType <Traveller>()
                      orderby p.BirthDate ascending
                      select p;
            return req.Take(3).ToList();
        }
        public List<Passenger> SeniorTravellers(Flight flight)
        {
            //var req= from p in flight.Passengers
            //         where p is Traveller
            //         orderby p.BirthDate ascending
            //         select p;
            //return req.Take(3).ToList();
            return flight.Passengers
                .Where(p => p is Traveller)
                .OrderBy(p => p.BirthDate)
                .Take(3)
                .ToList();
        }

        public void ShowFlightDetails(Plane plane)
        {
            //var req= from f in Flights
            //         where f.MyPlane == plane
            //         select f;

            var reqLambda= Flights
                .Where(f=>f.MyPlane==plane)
                .Select(f=>f);

            foreach (var f in reqLambda)
            {
                Console.WriteLine("Destination: "+f.Destination
                    +" Date: "+f.FlightDate);
            }
        }
    }
}
