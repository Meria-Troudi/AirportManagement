using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string EmailAddress { get; set; } = "";
        public string PassportNumber { get; set; } = "";
        public string FullName => $"{FirstName} {LastName}";

        // Polymorphisme par signature — surcharge
        public virtual bool CheckProfile(string lastName, string firstName)
        {
            return string.Equals(LastName, lastName, StringComparison.OrdinalIgnoreCase)
                && string.Equals(FirstName, firstName, StringComparison.OrdinalIgnoreCase);
        }
        public virtual bool CheckProfile(string lastName, string firstName, string email)
        {
            return CheckProfile(lastName, firstName)
                && string.Equals(EmailAddress, email, StringComparison.OrdinalIgnoreCase);
        }
        // Méthode combinée (remplace les deux précédentes)
        public virtual bool CheckProfile(params string[] parts)
        {
            // comportement simple : si 2 éléments -> last, first ; si 3 -> last, first, email
            if (parts.Length == 2) return CheckProfile(parts[0], parts[1]);
            if (parts.Length == 3) return CheckProfile(parts[0], parts[1], parts[2]);
            throw new ArgumentException("Expected 2 or 3 arguments: lastName, firstName[, email]");
        }

        // Polymorphisme par héritage (méthode virtual)
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }

        public override string ToString()
        {
            return $"Passenger[{Id}] {FirstName} {LastName} ({EmailAddress})";
        }
    }

}
