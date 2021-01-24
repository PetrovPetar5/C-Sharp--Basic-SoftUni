namespace SwimmingRecord
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distanceToSwim = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());
            double slowDowns = 0;
            if (distanceToSwim >= 15)
            {
                 slowDowns = Math.Floor(distanceToSwim / 15) * 12.5;
            }

            double timeSummed =(timeForMeter * distanceToSwim) + slowDowns;
            if (timeSummed < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeSummed:F2} seconds.");
            }
            else
            {
                double secondsover = timeSummed - worldRecord;
                Console.WriteLine($"No, he failed! He was {secondsover:F2} seconds slower.");
            }
        }
    }
}
