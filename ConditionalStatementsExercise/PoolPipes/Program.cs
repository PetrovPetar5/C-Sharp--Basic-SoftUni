namespace PoolPipes
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int firstPipeLimit = int.Parse(Console.ReadLine());
            int secondPipeLimit = int.Parse(Console.ReadLine());
            double hoursWorkerMisses = double.Parse(Console.ReadLine());
            double littersFilled = (firstPipeLimit + secondPipeLimit) * hoursWorkerMisses;
            double filledPercent = littersFilled / volume * 100;
            double firstPipePercent = firstPipeLimit * hoursWorkerMisses / littersFilled * 100;
            double secondPipePercent = secondPipeLimit * hoursWorkerMisses / littersFilled * 100;
            if (volume >= littersFilled)
            {
                Console.WriteLine($"The pool is {filledPercent:F2}% full. Pipe 1: {firstPipePercent:F2}%. Pipe 2: {secondPipePercent:F2}%.");
            }
            else if (volume < littersFilled)
            {
                double overFilled = littersFilled - volume;
                Console.WriteLine($"For {hoursWorkerMisses} hours the pool overflows with {overFilled} liters.");
            }
        }
    }
}
