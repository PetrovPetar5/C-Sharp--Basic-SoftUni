namespace RentACar
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string carType = String.Empty;
            double carExpense = 0;
            string carClass = String.Empty;
            switch (season)
            {
                case "Summer":
                    if (budget <= 100)
                    {
                        carType = "Cabrio";
                        carClass = "Economy class";
                        carExpense = budget * 0.35;
                    }
                    else if (100 < budget && budget <= 500)
                    {
                        carType = "Cabrio";
                        carClass = "Compact class";
                        carExpense = budget * 0.45;
                    }
                    else
                    {
                        carType = "Jeep";
                        carClass = "Luxury class";
                        carExpense = budget * 0.90;
                    }
                    break;
                case "Winter":
                    if (budget <= 100)
                    {
                        carType = "Jeep";
                        carClass = "Economy class";
                        carExpense = budget * 0.65;
                    }
                    else if (100 < budget && budget <= 500)
                    {
                        carType = "Jeep";
                        carClass = "Compact class";
                        carExpense = budget * 0.80;
                    }
                    else
                    {
                        carType = "Jeep";
                        carClass = "Luxury class";
                        carExpense = budget * 0.90;
                    }
                    break;
            }

            Console.WriteLine($"{carClass}");
            Console.WriteLine($"{carType} - {carExpense:F2}");
        }
    }
}

