namespace FuelTank
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine().ToLower();
            double tankLiters = double.Parse(Console.ReadLine());
            if (fuelType != "diesel" && fuelType != "gasoline" && fuelType != "gas")
            {
                Console.WriteLine("Invalid fuel!");
            }
            else if (tankLiters >= 25)
            {
                Console.WriteLine($"You have enough {fuelType}.");
            }
            else
            {
                Console.WriteLine($"Fill your tank with {fuelType}!");
            }
        }
    }
}

