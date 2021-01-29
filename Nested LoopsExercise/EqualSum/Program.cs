namespace EqualSum
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            for (int i = number1; i <= number2; i++)
            {
                int evenSum = 0;
                int oddSum = 0;
                string currNum = i.ToString();
                for (int j = 0; j < currNum.Length; j++)
                {
                    int currDigit = int.Parse(currNum[j].ToString());
                    if (j % 2 == 0)
                    {
                        oddSum += currDigit;
                    }
                    else
                    {
                        evenSum += currDigit;
                    }
                }

                if (evenSum == oddSum)
                {
                    Console.Write(currNum + " ");
                }
            }
        }
    }
}
