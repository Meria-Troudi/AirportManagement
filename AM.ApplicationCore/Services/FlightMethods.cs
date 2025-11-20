using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

      public List<DateTime> GetFlightDates(string destination)
        { 
            List<DateTime> result= new List<DateTime>();
            //for (int i= 0;i < Flights.Count; i++) {
            //    if(Flights[i].Destination == destination)
            //    {
            //   result.Add(Flights[i].FlightDate);
            //    }
            foreach (var flight in Flights)
            {
                if (flight.Destination == destination)
                {
                    result.Add(flight.FlightDate);
                }
            }
                return result;
            }
        public void getFlight(string filterType, string filterValue)
        {
            switch (filterType)
            {   case "Destination":
                    foreach (var flight in Flights)
                    {
                     if (flight.Destination == filterValue){
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "estimatedDuration":
                    foreach (var flight in Flights)
                    {
                        if (flight.EstimatedDuration > int.Parse(filterValue))
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

        public void GetFlight(string filterType, string filterValue)
        {
            throw new NotImplementedException();
        }
    }
}
