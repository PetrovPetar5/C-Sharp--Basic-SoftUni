namespace TradeCommision
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            decimal sales = decimal.Parse(Console.ReadLine());
            decimal commision = 0;
            if ((sales >= 0 && sales <= 500) && (town == "Varna" || town == "Sofia" || town == "Plovdiv"))
            {
                if (town == "Varna")
                {
                    commision = sales * 0.045m;
                }
                else if (town == "Sofia")
                {
                    commision = sales * 0.05m;
                }
                else if (town == "Plovdiv")
                {
                    commision = sales * 0.055m;
                }

                Console.WriteLine($"{commision:F2}");
            }
            else if ((sales > 500 && sales <= 1000) && (town == "Varna" || town == "Sofia" || town == "Plovdiv"))
            {
                if (town == "Varna")
                {
                    commision = sales * 0.075m;
                }
                else if (town == "Sofia")
                {
                    commision = sales * 0.07m;
                }
                else if (town == "Plovdiv")
                {
                    commision = sales * 0.08m;
                }

                Console.WriteLine($"{commision:F2}");
            }
            else if ((sales > 1000 && sales <= 10000) && (town == "Varna" || town == "Sofia" || town == "Plovdiv"))
            {
                if (town == "Varna")
                {
                    commision = sales * 0.1m;
                }
                else if (town == "Sofia")
                {
                    commision = sales * 0.08m;
                }
                else if (town == "Plovdiv")
                {
                    commision = sales * 0.12m;
                }

                Console.WriteLine($"{commision:F2}");
            }
            else if ((sales > 10000) && (town == "Varna" || town == "Sofia" || town == "Plovdiv"))
            {
                if (town == "Varna")
                {
                    commision = sales * 0.13m;
                }
                else if (town == "Sofia")
                {
                    commision = sales * 0.12m;
                }
                else if (town == "Plovdiv")
                {
                    commision = sales * 0.145m;
                }

                Console.WriteLine($"{commision:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}



