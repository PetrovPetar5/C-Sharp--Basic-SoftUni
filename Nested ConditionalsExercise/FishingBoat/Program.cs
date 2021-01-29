namespace FishingBoat
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishersCount = int.Parse(Console.ReadLine());
            double boatPrice = 0;
            double discount = 0;
            if (season == "Summer" || season == "Autumn")
            {
                boatPrice = 4200;
            }
            else if (season == "Spring")
            {
                boatPrice = 3000;
            }
            else
            {
                boatPrice = 2600;
            }

            if (fishersCount <= 6)
            {
                discount = boatPrice * 0.9;
            }
            else if (6 < fishersCount && fishersCount <= 11)
            {
                discount = boatPrice * 0.85;
            }
            else if (12 <= fishersCount)
            {
                discount = boatPrice * 0.75;
            }

            if (fishersCount % 2 == 0 && season != "Autumn")
            {
                discount *= 0.95;
            }

            double difference = Math.Abs(discount - budget);
            if (budget >= discount)
            {
                Console.WriteLine($"Yes! You have {difference:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {difference:F2} leva.");
            }
        }
    }
}
