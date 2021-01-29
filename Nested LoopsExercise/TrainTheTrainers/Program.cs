namespace TrainTheTrainers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int judgesNum = int.Parse(Console.ReadLine());
            double totalScore = 0;
            int presentationC = 0;
            string presentationTitle = Console.ReadLine();
            while (presentationTitle != "Finish")
            {
                presentationC++;
                double currPresentationScore = 0;
                int judgesC = 0;
                while (judgesC < judgesNum)
                {
                    double currJudge = double.Parse(Console.ReadLine());
                    currPresentationScore += currJudge;
                    judgesC++;
                }

                Console.WriteLine($"{presentationTitle} - {currPresentationScore / judgesNum:f2}.");
                double finalScore = currPresentationScore / judgesNum;
                totalScore += finalScore;
                presentationTitle = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {totalScore / presentationC:f2}.");
        }
    }
}
