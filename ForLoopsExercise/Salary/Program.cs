namespace Salary
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int tabsOpen = int.Parse(Console.ReadLine());
            decimal salary = decimal.Parse(Console.ReadLine());
            int facebookPenalty = 150;
            int instagramPenalty = 100;
            int redditPenalty = 50;
            decimal salaryLeft = salary;
            for (int counter = 0; counter < tabsOpen; counter++)
            {
                string currentTab = Console.ReadLine();
                if (currentTab == "Facebook")
                {
                    salaryLeft -= facebookPenalty;
                }
                else if (currentTab == "Instagram")
                {
                    salaryLeft -= instagramPenalty;
                }
                else if (currentTab == "Reddit")
                {
                    salaryLeft -= redditPenalty;
                }

                if (salaryLeft <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salaryLeft > 0)
            {
                Console.WriteLine($"{(int)salaryLeft}");
            }
        }
    }
}
