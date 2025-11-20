using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }

        // Relation 1-* Plane -> Flights
        public ICollection<Flight> Flights { get; set; } = new List<Flight>();

        // Constructeur non paramétré (par défaut fourni automatiquement si aucun autre constructeur présent)
        // Constructeur par défaut
        public Plane() { }

        // Constructeur paramétré
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            this.PlaneType = PlaneType;
            this.Capacity = capacity;
            this.ManufactureDate = date;
        }


        // Exemple de ToString
        public override string ToString()
        {
            return $"Plane[{PlaneId}] Type={PlaneType}, Capacity={Capacity}, Manufacture={ManufactureDate:yyyy-MM-dd}";
        }
    }

}
