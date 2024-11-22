using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public string PassportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int TelNumber { get; set; }
        public string EmailAddress { get; set; }
        public int Id { get; set; }


        public ICollection<Flight> Flights { get; set; }



        public override string ToString()
        {
            return "PassportNumber: " + PassportNumber + " FirstName: " + FirstName + " LastName: " + LastName + " BirthDate: " + BirthDate.ToShortDateString() + " TelNumber: " + TelNumber + " EmailAddress: " + EmailAddress;
        }
    }
}
