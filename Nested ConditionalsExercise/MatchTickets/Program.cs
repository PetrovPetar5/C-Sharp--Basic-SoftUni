namespace MatchTickets
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketCategory = Console.ReadLine();
            int fansNumber = int.Parse(Console.ReadLine());
            double transportPrice = 0;
            double ticketPrice = 0;
            if (fansNumber >= 1 && fansNumber <= 4)
            {
                transportPrice = budget * 0.75;
            }
            else if (fansNumber <= 9)
            {
                transportPrice = budget * 0.6;
            }
            else if (fansNumber <= 24)
            {
                transportPrice = budget * 0.5;
            }
            else if (fansNumber <= 49)
            {
                transportPrice = budget * 0.4;
            }
            else
            {
                transportPrice = budget * 0.25;
            }

            if (ticketCategory == "VIP")
            {
                ticketPrice = 499.99 * fansNumber;
            }
            else
            {
                ticketPrice = 249.99 * fansNumber;
            }

            double totalCost = ticketPrice + transportPrice;
            double difference = Math.Abs(totalCost - budget);
            if (totalCost > budget)
            {
                Console.WriteLine($"Not enough money! You need {difference:F2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {difference:F2} leva left.");
            }
        }
    }
}

