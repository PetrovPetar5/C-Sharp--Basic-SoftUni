namespace MetricConverter
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string incomeMetric = Console.ReadLine();
            string outcomeMetric = Console.ReadLine();
            double cmToM = number / 100;
            double mmToM = number / 1000;
            double mtoM = number;
            double result = 0;
            if (incomeMetric == "m")
            {
                if (outcomeMetric == "m")
                {

                    Console.WriteLine($"{number:F3}");
                }
                else if (outcomeMetric == "cm")
                {
                    result = number * 100;
                    Console.WriteLine($"{result:F3}");
                }
                else
                {
                    result = number * 1000;
                    Console.WriteLine($"{result:F3}");
                }
            }
            else if (incomeMetric == "cm")
            {
                if (outcomeMetric == "cm")
                {
                    Console.WriteLine($"{number:F3}");
                }
                else if (outcomeMetric == "m")
                {
                    Console.WriteLine($"{cmToM:F3}");
                }
                else
                {
                    result = number * 10;
                    Console.WriteLine($"{result:F3}");
                }
            }
            else if (incomeMetric == "mm")
            {
                if (outcomeMetric == "mm")
                {
                    Console.WriteLine($"{number:F3}");
                }
                else if (outcomeMetric == "cm")
                {
                    result = number / 10;

                    Console.WriteLine($"{result:F3}");
                }
                else
                {
                    result = number / 1000;

                    Console.WriteLine($"{result:F3}");
                }
            }

        }
    }
}


