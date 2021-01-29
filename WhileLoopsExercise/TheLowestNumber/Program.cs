namespace TheLowestNumber
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int numberInputs = int.Parse(Console.ReadLine());
            int lowestNum = int.MaxValue;
            int counter = 0;
            while (counter < numberInputs)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < lowestNum)
                {
                    lowestNum = currentNumber;
                }

                counter++;
            }

            Console.WriteLine("{0}", lowestNum);
        }
    }
}
