namespace Vacation
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string accomodation = String.Empty;
            string location = String.Empty;
            decimal vacationExpense = 0;
            switch (season)
            {
                case "Summer":
                    location = "Alaska";
                    if (1000 >= budget)
                    {
                        accomodation = "Camp";
                        vacationExpense = budget * 0.65m;
                    }
                    else if (1000 < budget && budget <= 3000)
                    {
                        accomodation = "Hut";
                        vacationExpense = budget * 0.8m;
                    }
                    else
                    {
                        accomodation = "Hotel";
                        vacationExpense = budget * 0.9m;
                    }
                    break;
                case "Winter":
                    location = "Morocco";
                    if (1000 >= budget)
                    {
                        accomodation = "Camp";
                        vacationExpense = budget * 0.45m;
                    }
                    else if (1000 < budget && budget <= 3000)
                    {
                        accomodation = "Hut";
                        vacationExpense = budget * 0.6m;
                    }
                    else
                    {
                        accomodation = "Hotel";
                        vacationExpense = budget * 0.9m;
                    }
                    break;
            }

            Console.WriteLine($"{location} - {accomodation} - {vacationExpense:F2}");
        }
    }
}

