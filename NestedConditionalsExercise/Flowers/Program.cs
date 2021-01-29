namespace Flowers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemum = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holidayOrNot = Console.ReadLine();
            double chrysanthemumPrice = 0;
            double rosesPrice = 0;
            double tuliPrice = 0;
            double totalPrice = 0;
            switch (season)
            {
                case "Spring":
                case "Summer":
                    chrysanthemumPrice = 2 * chrysanthemum;
                    rosesPrice = 4.10 * roses;
                    tuliPrice = 2.5 * tulips;
                    totalPrice = chrysanthemumPrice + rosesPrice + tuliPrice;
                    if (holidayOrNot == "Y")
                    {
                        totalPrice *= 1.15;
                    }

                    if (season == "Spring" && tulips > 7)
                    {
                        totalPrice *= 0.95;
                    }
                    break;
                case "Autumn":
                case "Winter":
                    chrysanthemumPrice = 3.75 * chrysanthemum;
                    rosesPrice = 4.50 * roses;
                    tuliPrice = 4.15 * tulips;
                    totalPrice = chrysanthemumPrice + rosesPrice + tuliPrice;
                    if (holidayOrNot == "Y")
                    {
                        totalPrice *= 1.15;
                    }

                    if (season == "Winter" && roses >= 10)
                    {
                        totalPrice *= 0.90;
                    }
                    break;
            }
            if (chrysanthemum + roses + tulips > 20)
            {
                totalPrice *= 0.8;
            }

            Console.WriteLine($"{totalPrice + 2:F2}");
        }
    }
}

