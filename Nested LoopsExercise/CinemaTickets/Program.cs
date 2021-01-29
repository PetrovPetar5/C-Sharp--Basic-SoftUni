namespace CinemaTickets
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string ticketType = string.Empty;
            int totalTicketsC = 0;
            double watchersPercent = 0;
            int ticketsKidsC = 0;
            int ticketsStudentC = 0;
            int ticketsStandardC = 0;
            bool isFinish = false;
            while (true)
            {
                string movieName = Console.ReadLine();
                if (movieName == "Finish")
                {
                    isFinish = true;
                    break;
                }
                int ticketCounter = 0;
                int curMovieFreeSeats = int.Parse(Console.ReadLine());
                for (int i = 1; i <= curMovieFreeSeats; i++)
                {
                    ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    else if (ticketType == "student")
                    {
                        ticketsStudentC++;
                    }
                    else if (ticketType == "standard")
                    {
                        ticketsStandardC++;
                    }
                    else
                    {
                        ticketsKidsC++;
                    }

                    totalTicketsC++;
                    ticketCounter++;
                }

                watchersPercent = ticketCounter * 1.0 / curMovieFreeSeats * 100;
                Console.WriteLine($"{movieName} - {watchersPercent:f2}% full.");
            }

            if (isFinish)
            {
                Console.WriteLine($"Total tickets: {totalTicketsC}");
                Console.WriteLine($"{ticketsStudentC * 1.0 / totalTicketsC * 100:f2}% student tickets.");
                Console.WriteLine($"{ticketsStandardC * 1.0 / totalTicketsC * 100:f2}% standard tickets.");
                Console.WriteLine($"{ticketsKidsC * 1.0 / totalTicketsC * 100:f2}% kids tickets.");
            }
        }
    }
}
