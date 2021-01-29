namespace GoingBackInPast
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double inheritance = double.Parse(Console.ReadLine());
            int yearWithoutWorking = int.Parse(Console.ReadLine());
            double evenYearsSpent = 0;
            double oddYearsSpent = 0;
            int years = 18;
            for (int counter = 1800; counter <= yearWithoutWorking; counter++)
            {
                if ((counter + 1800) % 2 == 0)
                {
                    evenYearsSpent += 12000;
                }
                else
                {
                    oddYearsSpent += 12000 + (50 * years);
                }
                
                years++;
            }

            double totalSpent = evenYearsSpent + oddYearsSpent;
            double difference = Math.Abs(totalSpent - inheritance);
            if (inheritance >= totalSpent)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {difference:F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {difference:F2} dollars to survive.");
            }
        }
    }
}
