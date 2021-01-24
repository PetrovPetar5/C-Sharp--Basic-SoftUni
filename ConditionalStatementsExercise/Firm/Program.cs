namespace Firm
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int hoursRequired = int.Parse(Console.ReadLine());
            int daysAvailable = int.Parse(Console.ReadLine());
            int employeesWorkingExtraCount = int.Parse(Console.ReadLine());
            double hoursAfterCourse = (daysAvailable * 8) * 0.9;
            double employeesWorkingExtraHours = employeesWorkingExtraCount * daysAvailable * 2.0;
            double totalHourSpent = Math.Floor(hoursAfterCourse + employeesWorkingExtraHours);
            double difference = Math.Abs(totalHourSpent - hoursRequired);
            if (hoursRequired <= totalHourSpent)
            {
                Console.WriteLine($"Yes!{Math.Floor(difference)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Floor(difference)} hours needed.");
            }
        }
    }
}
