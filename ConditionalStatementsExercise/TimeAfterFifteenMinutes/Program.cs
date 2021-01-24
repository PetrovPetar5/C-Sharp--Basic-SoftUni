namespace TimeAfterFifteenMinutes
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int currentHour = int.Parse(Console.ReadLine());
            int currentMinute = int.Parse(Console.ReadLine());
            int timeAfterFifteenMinutes = currentMinute + 15;
            int minutesLeft = timeAfterFifteenMinutes % 60;
            if (timeAfterFifteenMinutes >= 60)
            {
                currentHour += 1;
            }

            if (currentHour == 24)
            {

                Console.WriteLine($"{0}:{minutesLeft:D2}");
            }
            else
            {
                Console.WriteLine($"{currentHour}:{minutesLeft:D2}");
            }
        }
    }
}
