namespace PassGenerator
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int sOne = 1; sOne <= n; sOne++)
            {
                for (int sTwo = 1; sTwo <= n; sTwo++)
                {
                    for (char sThree = 'a'; sThree < sThree + l; sThree++)
                    {
                        for (char sFour = 'a'; sFour < sFour + l; sFour++)
                        {
                            for (int sFive = 1; sFive <= n; sFive++)
                            {
                                if (sFive > sOne && sFive > sTwo)
                                {
                                    Console.Write($"{sOne}{sTwo}{sThree}{sFour}{sFive} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
