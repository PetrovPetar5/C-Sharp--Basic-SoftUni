namespace OddOrEvenSum
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int evenTotal = 0;
            int oddTotal = 0;
            for (int i = 0; i < numberOfInputs; i++)
            {
                int currentNumber = i + 1;
                int currentF = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == 0)
                {
                    evenTotal += currentF;
                }
                else
                {
                    oddTotal += currentF;
                }
            }

            if (evenTotal == oddTotal)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", oddTotal);
            }
            else
            {
                int difference = Math.Abs(oddTotal - evenTotal);
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", difference);
            }
        }
    }
}

