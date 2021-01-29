namespace GameOfIntervals
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int totalTurns = int.Parse(Console.ReadLine());
            double totalPoints = 0;
            int zeroNine = 0;
            int tenNineteen = 0;
            int twentyTwentynine = 0;
            int thirtyThirtynine = 0;
            int fortyFifty = 0;
            int invalidNumber = 0;

            for (int counter = 0; counter < totalTurns; counter++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (0 > currentNumber || currentNumber > 50)
                {
                    totalPoints /= 2;
                    invalidNumber++;
                }
                else if (0 <= currentNumber && currentNumber <= 9)
                {
                    totalPoints += currentNumber * 0.20;
                    zeroNine++;
                }
                else if (10 <= currentNumber && currentNumber <= 19)
                {
                    totalPoints += currentNumber * 0.30;
                    tenNineteen++;
                }
                else if (20 <= currentNumber && currentNumber <= 29)
                {
                    totalPoints += currentNumber * 0.40;
                    twentyTwentynine++;
                }
                else if (30 <= currentNumber && currentNumber <= 39)
                {
                    totalPoints += 50;
                    thirtyThirtynine++;
                }
                else if (40 <= currentNumber && currentNumber <= 50)
                {
                    totalPoints += 100;
                    fortyFifty++;
                }
            }

            Console.WriteLine($"{totalPoints:F2}");
            Console.WriteLine($"From 0 to 9: {zeroNine / (double)totalTurns * 100:F2}%");
            Console.WriteLine($"From 10 to 19: {tenNineteen / (double)totalTurns * 100:F2}%");
            Console.WriteLine($"From 20 to 29: {twentyTwentynine / (double)totalTurns * 100:F2}%");
            Console.WriteLine($"From 30 to 39: {thirtyThirtynine / (double)totalTurns * 100:F2}%");
            Console.WriteLine($"From 40 to 50: {fortyFifty / (double)totalTurns * 100:F2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumber / (double)totalTurns * 100:F2}%");
        }
    }
}
