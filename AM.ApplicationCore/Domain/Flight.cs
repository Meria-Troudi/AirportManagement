using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string? AirlineLogo { get; set; }
        public string? Departure { get; set; }
        public string? Destination { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public double EstimatedDuration { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        [ForeignKey("MyPlane")]
        public int PlaneId { get; set; }//clé étrangère
       
       // [ForeignKey("PlaneId")]
        public virtual Plane MyPlane { get; set; }//prop de navigation
        public virtual ICollection<Passenger> Passengers { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public override string ToString()
        {
            return " FlightId: "+ this.FlightId
                + " EstimatedDuration: "+ this.EstimatedDuration;
        }
    }
}
