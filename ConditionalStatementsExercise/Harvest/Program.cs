namespace Harvest
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int yardArea = int.Parse(Console.ReadLine());
            double grapePerMeter = double.Parse(Console.ReadLine());
            int litersNeeded = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());
            double vineYardArea = yardArea * 0.4;
            double grapeKG = vineYardArea * grapePerMeter;
            double litersAmount = grapeKG / 2.5;
            double differance = Math.Abs(litersNeeded - litersAmount);
            if (litersNeeded > litersAmount)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(differance)} liters wine needed.");
            }
            else
            {
                double litterPerWorker = differance / numberOfWorkers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litersAmount)} liters.");
                Console.WriteLine($"{Math.Ceiling(differance)} liters left -> {Math.Ceiling(litterPerWorker)} liters per person.");
            }
        }
    }
}
