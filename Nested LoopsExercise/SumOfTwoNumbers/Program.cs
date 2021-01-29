namespace SumOfTwoNumbers

{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinationC = 0;
            int combinationSum = 0;
            bool isFound = false;
            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = startNum; j <= endNum; j++)
                {
                    combinationC++;
                    combinationSum = i + j;
                    if (combinationSum == magicNum)
                    {
                        startNum = i;
                        endNum = j;
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine($"Combination N:{ combinationC} ({startNum} + {endNum} = {magicNum})");
            }
            else
            {
                Console.WriteLine($"{combinationC} combinations - neither equals {magicNum}");
            }
        }
    }
}
