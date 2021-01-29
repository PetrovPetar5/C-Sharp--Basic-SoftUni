namespace OpenTheSecretDoor
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int hundredsLimit = int.Parse(Console.ReadLine());
            int decimalLimit = int.Parse(Console.ReadLine());
            int unitLimit = int.Parse(Console.ReadLine());
            for (int i = 1; i <= hundredsLimit; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }

                for (int k = 1; k <= decimalLimit; k++)
                {
                    if (k != 2 && k != 3 && k != 5 && k != 7)
                    {
                        continue;
                    }
                    for (int j = 1; j <= unitLimit; j++)
                    {
                        if (j % 2 != 0)
                        {
                            continue;
                        }

                        Console.WriteLine($"{i} {k} {j}");
                    }
                }
            }
        }
    }
}
