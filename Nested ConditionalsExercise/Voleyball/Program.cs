namespace Voleyball
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string leapOrNot = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsInHometown = int.Parse(Console.ReadLine());
            int weekendsInSofia = 48 - weekendsInHometown;
            double saturdayGamesInSofia = 0.75 * weekendsInSofia;
            double holidaysToPlay = 2.0 / 3;
            double totalTimeForPlayingOnHolidays = holidays * holidaysToPlay;
            double gamesOnSunday = weekendsInHometown;
            double totalGames = saturdayGamesInSofia + totalTimeForPlayingOnHolidays + gamesOnSunday;
            if (leapOrNot == "leap")
            {
                totalGames *= 1.15;
                Console.WriteLine(Math.Floor(totalGames));
            }
            else
            {
                Console.WriteLine(Math.Floor(totalGames));
            }
        }
    }
}

