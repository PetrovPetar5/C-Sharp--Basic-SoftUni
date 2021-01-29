namespace SingingWheels
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int controlNum = int.Parse(Console.ReadLine());
            int validNumC = 0;
            string password = string.Empty;
            bool isFound = false;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a < b && c > d)
                            {
                                if ((a * b + c * d) == controlNum)
                                {
                                    validNumC++;
                                    Console.Write($"{a}{b}{c}{d} ");
                                    if (validNumC == 4)
                                    {
                                        isFound = true;
                                        password = $"{a}{b}{c}{d}";
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (isFound)
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {password}");
            }
            else if (validNumC == 0)
            {
                Console.WriteLine("No!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No!");
            }
        }
    }
}
