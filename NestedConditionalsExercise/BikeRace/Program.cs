namespace BikeRace
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int juniorCompetitors = int.Parse(Console.ReadLine());
            int seniorCompetitors = int.Parse(Console.ReadLine());
            string trackType = Console.ReadLine();
            double seniorIncome = 0;
            double juniorIncome = 0;
            double totalIncome = 0;
            switch (trackType)
            {
                case "trail":
                    seniorIncome = seniorCompetitors * 7;
                    juniorIncome = 5.5 * juniorCompetitors;
                    break;
                case "cross-country":
                    seniorIncome = seniorCompetitors * 9.5;
                    juniorIncome = 8 * juniorCompetitors;
                    break;
                case "downhill":
                    seniorIncome = seniorCompetitors * 13.75;
                    juniorIncome = 12.25 * juniorCompetitors;
                    break;
                case "road":
                    seniorIncome = seniorCompetitors * 21.5;
                    juniorIncome = juniorCompetitors * 20;
                    break;
            }

            totalIncome = seniorIncome + juniorIncome;
            if (juniorCompetitors + seniorCompetitors >= 50 && trackType == "cross-country")
            {
                totalIncome *= 0.75;
            }

            totalIncome *= 0.95;
            Console.WriteLine("{0:F2}", totalIncome);
        }
    }
}
