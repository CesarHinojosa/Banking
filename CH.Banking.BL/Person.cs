using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CH.Banking.BL
{
    public class Person
    {
        
        public string SSN { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

        //Created a method to get the age from the date of birth
        public int Age { get { return CalculateAge(); } }

        public DateTime DateOfBirth { get; set; }

        //using the override keyword so that the method has its own signature  
        public override string ToString()
        {
            return FullName;
        }

        public int CalculateAge()
        {
            TimeSpan span = DateTime.Now - DateOfBirth;
            return (int)(span.TotalDays / 365.25);
        }

        
    }
}