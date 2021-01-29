namespace HappyCatParking
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for (int a = 1; a <= days; a++)
            {
                bool isEven = false;
                if (a % 2 == 0)
                {
                    isEven = true;
                }

                double dayCost = 0;
                for (int b = 1; b <= hours; b++)
                {
                    bool isOddH = false;
                    if (b % 2 != 0)
                    {
                        isOddH = true;
                    }

                    if (isEven && isOddH)
                    {
                        dayCost += 2.5;
                    }
                    else if (!isEven && !isOddH)
                    {
                        dayCost += 1.25;
                    }
                    else
                    {
                        dayCost += 1;
                    }
                }

                Console.WriteLine($"Day: {a} - {dayCost:f2} leva");
                totalPrice += dayCost;
            }

            Console.WriteLine($"Total: {totalPrice:f2} leva");
        }
    }
}

