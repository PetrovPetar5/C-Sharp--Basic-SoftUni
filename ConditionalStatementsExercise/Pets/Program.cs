namespace Pets
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int tripDaysAbsence = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());
            double turtleFoodKG = turtleFood / 1000;
            double foodNeeded = (dogFood + catFood + turtleFoodKG) * tripDaysAbsence;
            double difference = Math.Abs(foodNeeded - foodLeft);
            if (foodLeft >= foodNeeded)
            {
                Console.WriteLine($"{Math.Floor(difference)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(difference)} more kilos of food are needed.");
            }
        }
    }
}
