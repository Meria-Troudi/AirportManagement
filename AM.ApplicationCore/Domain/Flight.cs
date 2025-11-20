using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string? Departure { get; set; }
        public string? Destination { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; } // minutes
        public DateTime FlightDate { get; set; }

        public Plane Plane { get; set; } = null!;
        public ICollection<Passenger> Passengers { get; set; } = new List<Passenger>();

  
        public override string ToString()
        {
 
            return ("Destination: " + this.Destination + ", estimated duration :" + this.EstimatedDuration +", flightDate :"+ FlightDate +" \n");
        }
    }

}
