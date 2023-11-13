namespace Cars_and_Used_Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car1 = new Car($"Cadillac\t\t","Escalade\t", 2024, 70000.00m); // this is an instance of a Car or object
           Car car2 = new Car("Volvo\t\t","V60\t\t", 2024, 49750.00m);
           Car car3 = new Car("Jeep\t\t", "Wagoneer\t", 2024, 65000.00m);

           UsedCar usedCar1 = new UsedCar("Ford\t\t","Escape\t\t",2009,15000.00m, 89000); 
           UsedCar usedCar2 = new UsedCar("Scion\t\t","xB\t\t", 2009, 12000.00m, 99000);
           UsedCar usedCar3 = new UsedCar("Ford\t\t","F150\t\t", 2012, 12000.00m, 100000);

            Car.Cars.Add(car1);  // Cars(the List) can be considered a member
            Car.Cars.Add(car2);
            Car.Cars.Add(car3);
            Car.Cars.Add(usedCar1);
            Car.Cars.Add(usedCar2);
            Car.Cars.Add(usedCar3);

            Car.ListCars();

            Console.WriteLine($"\nWhich car would you like to buy?");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int result) )
            Console.WriteLine($"\nYou chose car {userInput}\n\n{Car.Cars[result]}:");

            Car.Remove(result);
            Console.WriteLine("\nRemaining options:\n");
            Car.ListCars();

        }
    }
}