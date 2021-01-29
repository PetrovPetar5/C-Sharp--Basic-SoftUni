namespace Logistic
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int loadsNumber = int.Parse(Console.ReadLine());
            int lorryPerTon = 200;
            int truckPerTon = 175;
            int trainPerTon = 120;
            int lorryTons = 0;
            int truckTons = 0;
            int trainTons = 0;
            int totalTons = 0;
            for (int counter = 0; counter < loadsNumber; counter++)
            {
                int currentTons = int.Parse(Console.ReadLine());
                if (currentTons <= 3)
                {
                    lorryTons += currentTons;
                }
                else if (4 <= currentTons && currentTons <= 11)
                {
                    truckTons += currentTons;
                }
                else
                {
                    trainTons += currentTons;
                }

                totalTons += currentTons;
            }

            double totalLorry = lorryTons * lorryPerTon;
            double totalTruck = truckTons * truckPerTon;
            double totalTrain = trainTons * trainPerTon;
            double averagePerTon = (totalLorry + totalTruck + totalTrain) / totalTons;
            Console.WriteLine($"{averagePerTon:F2}");
            Console.WriteLine($"{lorryTons / (double)totalTons * 100:F2}%");
            Console.WriteLine($"{truckTons / (double)totalTons * 100:F2}%");
            Console.WriteLine($"{trainTons / (double)totalTons * 100:F2}%");
        }
    }
}
