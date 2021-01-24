namespace Scolarship
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            decimal income = decimal.Parse(Console.ReadLine());
            decimal averageGrade = decimal.Parse(Console.ReadLine());
            decimal minimalWage = decimal.Parse(Console.ReadLine());
            decimal socialScolarship = 0;
            decimal scolarship = 0;
            if (averageGrade >= 5.5m)
            {
                scolarship = averageGrade * 25m;
            }

            if (income < minimalWage)
            {
                if (averageGrade > 4.5m)
                {
                    socialScolarship = minimalWage * 0.35m;
                }
            }

            if (scolarship > socialScolarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scolarship)} BGN");
            }
            else if (socialScolarship > scolarship)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScolarship)} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}





