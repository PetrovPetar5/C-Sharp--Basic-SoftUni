namespace Journey
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string tripPlace = String.Empty;
            string facility = String.Empty;
            if (budget > 1000)
            {
                tripPlace = "Europe";
                facility = "Hotel";
                budget *= 0.90;
            }
            else if (budget <= 100)
            {
                if (season == "summer")
                {
                    budget *= 0.3;
                    tripPlace = "Bulgaria";
                    facility = "Camp";
                }
                else if (season == "winter")
                {
                    tripPlace = "Bulgaria";
                    facility = "Hotel";
                    budget *= 0.7;
                }
            }
            else
            {
                if (season == "summer")
                {
                    budget *= 0.4;
                    facility = "Camp";
                    tripPlace = "Balkans";
                }
                else if (true)
                {
                    budget *= 0.8;
                    facility = "Hotel";
                    tripPlace = "Balkans";
                }
            }

            Console.WriteLine($"Somewhere in {tripPlace}");
            Console.WriteLine($"{facility} - {budget:F2}");
        }
    }
}
