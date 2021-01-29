namespace TruckDriver
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            decimal kmPerMonth = decimal.Parse(Console.ReadLine());
            decimal monthlySalary = 0;
            if (season == "Spring" || season == "Autumn")
            {
                if (kmPerMonth <= 5000)
                {
                    monthlySalary = kmPerMonth * 0.75m;
                }
                else if (5000 < kmPerMonth && kmPerMonth <= 10000)
                {
                    monthlySalary = kmPerMonth * 0.95m;
                }
                else
                {
                    monthlySalary = kmPerMonth * 1.45m;
                }
            }
            else if (season == "Summer")
            {
                if (kmPerMonth <= 5000)
                {
                    monthlySalary = kmPerMonth * 0.90m;
                }
                else if (5000 < kmPerMonth && kmPerMonth <= 10000)
                {
                    monthlySalary = kmPerMonth * 1.10m;
                }
                else
                {
                    monthlySalary = kmPerMonth * 1.45m;
                }
            }
            else if (season == "Winter")
            {
                if (kmPerMonth <= 5000)
                {
                    monthlySalary = kmPerMonth * 1.05m;
                }
                else if (5000 < kmPerMonth && kmPerMonth <= 10000)
                {
                    monthlySalary = kmPerMonth * 1.25m;
                }
                else
                {
                    monthlySalary = kmPerMonth * 1.45m;
                }
            }

            monthlySalary *= 0.9m;
            decimal totalEarnings = 4m * monthlySalary;
            Console.WriteLine("{0:F2}", totalEarnings);
        }
    }
}

