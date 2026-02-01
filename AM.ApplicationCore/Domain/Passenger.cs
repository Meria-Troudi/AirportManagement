using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        //public int Id { get; set; }

        [Display(Name ="Date of birth")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }

        //[DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [MinLength(3,ErrorMessage ="Longueur Minimale=3!")]
        [MaxLength(25, ErrorMessage ="Longueur Maximale=25!") ]
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
        [Key]
        [StringLength(7)]
        public string PassportNumber { get; set; }
        [RegularExpression(@"^[0-9]{8}$")]
        public string TelNumber { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public override string ToString()
        {
            return "FirstName: " + this.FirstName
                + " LastName: " + this.LastName
                + " EmailAddress: " + this.EmailAddress;
        }
        //public bool CheckProfile(string firstname, string lastname)
        //{
        //    return this.FirstName == firstname
        //        &&
        //        this.LastName == lastname;

        //}
        //public bool CheckProfile(string firstname, string lastname,string email)
        //{
        //    return this.FirstName == firstname
        //        &&
        //        this.LastName == lastname
        //        &&
        //        this.EmailAddress == email;

        //}
        public bool CheckProfile(string firstname, string lastname, string email = null)
        {
            if (email == null)
            {
                return this.FirstName == firstname
                    && this.LastName == lastname;
            }
            else
            {
                return this.FirstName == firstname
                    && this.LastName == lastname
                && this.EmailAddress == email;


            }
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I'm a passenger ");
        }

    }
}
