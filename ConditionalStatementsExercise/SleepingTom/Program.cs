namespace SleepingTom
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int dayOffs = int.Parse(Console.ReadLine());
            int workingDays = 365 - dayOffs;
            int workingDaysTimeSpent = workingDays * 63;
            int dayOffTimeSpent = dayOffs * 127;
            int yearEndTime = workingDaysTimeSpent + dayOffTimeSpent;
            int norm = 30000;
            int timedifference = Math.Abs(norm - yearEndTime);
            int hours = timedifference / 60;
            int minutes = timedifference % 60;
            if (norm < yearEndTime)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else if (norm >= yearEndTime)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
