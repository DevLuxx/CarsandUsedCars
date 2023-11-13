using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_Used_Cars
{
    public class Car
    {
        private string make;  // Data members for car details
        private string model;
        private int year;
        private decimal price;

        public static List<Car> Cars = new List<Car>();

        public Car() // No-arguments constructor w/ default values
        {
            make = "";
            model = "";
            year = 0;
            price = 0.0m;
        }

        public Car(string make, string model, int year, decimal price) // Constructor with four arguments
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Make: {make} \nModel: {model} \nYear: {year} \nPrice: {price} \n";  // creating ToString() method for car details
        }

        public static void ListCars()
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine($"Car number: {i + 1}\n");
                Console.WriteLine(Cars[i].ToString());
            }
        }

        public static void Remove(int theIndex)
        {
            if (theIndex > Cars.Count - 1 || theIndex < 0)
            {
                Console.WriteLine("Please try again.");
            }
            else
            {
                Cars.RemoveAt(theIndex);
            }

            Console.WriteLine(theIndex);
        }
    }
}

