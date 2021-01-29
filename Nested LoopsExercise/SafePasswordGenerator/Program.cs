namespace SafePasswordGenerator
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPasswords = int.Parse(Console.ReadLine());
            int passCount = 0;
            int A = 35;
            int B = 64;
            while (A <= 55)
            {
                while (B <= 96)
                {
                    for (int i = 1; i <= a; i++)
                    {
                        for (int k = 1; k <= b; k++)
                        {
                            char one = (char)A;
                            char two = (char)B;
                            Console.Write($"{one}{two}{i}{k}{two}{one}|");
                            passCount++;
                            A++;
                            B++;
                            if (passCount >= maxPasswords || (i == a && k == b))
                            {
                                return;
                            }

                            if (A > 55)
                            {
                                A = 35;
                            }

                            if (B > 96)
                            {
                                B = 64;
                            }
                        }
                    }
                }
            }
        }
    }
}
