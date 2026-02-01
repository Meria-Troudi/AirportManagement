using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IFlightMethods
    {
        List<DateTime> GetFlightDates(string destination);
        void GetFlights(string filterType, string filterValue);
        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        double DurationAverage(string destination);
        List<Flight> OrderedDurationFlights();
        List<Passenger> SeniorTravellers(Flight flight);
        List<IGrouping<string, Flight>> DestinationGroupedFlights();

    }
}
