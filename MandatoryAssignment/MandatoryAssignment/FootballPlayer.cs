using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignment
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }


        public void ValidateName()
        {
            if(string.IsNullOrWhiteSpace(Name)) throw new ArgumentException("Name must not be empty or null");
            if (Name.Length <= 1) throw new ArgumentOutOfRangeException("Name must be at least 2 characters long");
        }

        public void ValidateAge()
        {
            if(Age <= 1) throw new ArgumentOutOfRangeException("The player cannot be younger than 2");
        }

        public void ValidateShirtNumber()
        {
            if (ShirtNumber <= 0) throw new ArgumentOutOfRangeException("Shirt number has to be 1 or above");
            if (ShirtNumber >= 100) throw new ArgumentOutOfRangeException("Shirt number has to be 99 or below");
        }

        public void Validate()
        {
            ValidateName();
            ValidateAge();
            ValidateShirtNumber();
        }
    }
}
