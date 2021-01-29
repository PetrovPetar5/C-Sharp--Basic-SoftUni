namespace SchoolCamp
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string sport = String.Empty;
            decimal nightsPrice = 0;
            switch (season)
            {
                case "Winter":
                    if (groupType == "boys")
                    {
                        sport = "Judo";
                    }
                    else if (groupType=="girls")
                    {
                        sport = "Gymnastics";
                    }
                    else
                    {
                        sport = "Ski";
                    }

                    if (groupType == "boys" || groupType == "girls")
                    {
                        nightsPrice = nights * 9.60m;
                    }
                    else
                    {
                        nightsPrice = nights * 10;
                    }
                    break;
                case "Spring":
                    if (groupType == "boys")
                    {
                        sport = "Tennis";
                    }
                    else if (groupType == "girls")
                    {
                        sport = "Athletics";
                    }
                    else
                    {
                        sport = "Cycling";
                    }

                    if (groupType == "boys" || groupType == "girls")
                    {
                        nightsPrice = nights * 7.20m;
                    }
                    else
                    {
                        nightsPrice = nights * 9.50m;
                    }
                    break;
                case "Summer":
                    if (groupType == "boys")
                    {
                        sport = "Football";
                    }
                    else if (groupType == "girls")
                    {
                        sport = "Volleyball";
                    }
                    else
                    {
                        sport = "Swimming";
                    }

                    if (groupType == "boys" || groupType == "girls")
                    {
                        nightsPrice = nights * 15;
                    }
                    else
                    {
                        nightsPrice = nights * 20;
                    }
                    break;
            }

            if (students >= 50)
            {
                nightsPrice *= 0.5m;
            }
            else if (students >=20)
            {
                nightsPrice *= 0.85m;
            }
            else if (students >=10)
            {
                nightsPrice *= 0.95m;
            }

            decimal campTotalPrice = nightsPrice * students;
            Console.WriteLine("{0} {1:F2} lv.", sport, campTotalPrice);
        }
    }
}
