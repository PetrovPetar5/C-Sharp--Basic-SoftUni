namespace PyramidNumbers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isValid = false;
            for (int row = 1; row <= number; row++)
            {
                for (int i = 1; i <= row; i++)
                {
                    Console.Write(counter + 1 + " ");
                    counter++;
                    if (counter == number)
                    {
                        isValid = true;
                        break;
                    }
                }

                if (isValid)
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}

