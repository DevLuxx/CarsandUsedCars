using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_Used_Cars
{
    public class UsedCar : Car
    {
        private double mileage;  // Data member for used car details

        public UsedCar(string make, string model, int year, decimal price, double mileage)  // Constructor
            : base(make, model, year, price) // Call the four-argument constructor of Car
        {
            this.mileage = mileage;
        }

        public override string ToString()  // ToString() method for UsedCar
        {
            return base.ToString() + $"Mileage: {mileage} miles\n";
        }
    }
}

