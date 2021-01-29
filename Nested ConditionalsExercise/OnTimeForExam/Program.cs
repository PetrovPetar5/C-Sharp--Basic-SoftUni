namespace OnTimeForExam
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int examStartingHour = int.Parse(Console.ReadLine());
            int examStartingMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());
            int examTotalMinutes = examStartingHour * 60 + examStartingMinute;
            int arrivalTotalMinutes = arrivalHour * 60 + arrivalMinute;
            int difference = Math.Abs(arrivalTotalMinutes - examTotalMinutes);
            int hoursDifference = difference / 60;
            int minutesDifference = difference % 60;
            if (examTotalMinutes >= arrivalTotalMinutes && examTotalMinutes - arrivalTotalMinutes <= 30)
            {
                Console.WriteLine("On time");
                if (!(examTotalMinutes - arrivalTotalMinutes == 0))
                {
                    Console.WriteLine($"{minutesDifference} minutes before the start");
                }
            }
            else if (examTotalMinutes > arrivalTotalMinutes && examTotalMinutes - arrivalTotalMinutes > 30)
            {
                Console.WriteLine("Early");
                if (hoursDifference > 0)
                {
                    Console.WriteLine($"{hoursDifference}:{minutesDifference:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{minutesDifference} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Late");
                if (hoursDifference > 0)
                {
                    Console.WriteLine($"{hoursDifference}:{minutesDifference:D2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{minutesDifference} minutes after the start");
                }
            }
        }
    }
}

