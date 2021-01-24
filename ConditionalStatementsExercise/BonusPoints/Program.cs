namespace BonusPoints
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            decimal bonusPoints = 0;
            decimal additionalBonusPoints = 0;

            if (number <= 100)
            {
                bonusPoints = 5;
            }
            else if (number <= 1000)
            {
                bonusPoints = number * 0.20m;
            }
            else
            {
                bonusPoints = number * 0.1m;
            }

            if (number % 2 == 0)
            {
                additionalBonusPoints = additionalBonusPoints + 1;
            }
            else if (number % 10 == 5)
            {
                additionalBonusPoints = additionalBonusPoints + 2;
            }

            decimal totalBonusPoints = bonusPoints + additionalBonusPoints;
            Console.WriteLine(totalBonusPoints);
            Console.WriteLine(totalBonusPoints + number);
        }
    }
}
