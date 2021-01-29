namespace ExamPreparation
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int numPoorGradesLim = int.Parse(Console.ReadLine());
            int poorGradesCounter = 0;
            double totalGradeSum = 0;
            string lastProblem = String.Empty;
            int problemsCount = 0;
            bool enough = false;
            while (poorGradesCounter < numPoorGradesLim)
            {
                string currentProblem = Console.ReadLine();
                if (currentProblem == "Enough")
                {
                    enough = true;
                    break;
                }

                int problemMark = int.Parse(Console.ReadLine());
                if (problemMark <= 4)
                {
                    poorGradesCounter++;
                }

                totalGradeSum += problemMark;
                lastProblem = currentProblem;
                problemsCount++;
            }

            double averageMark = totalGradeSum / problemsCount;
            if (enough)
            {
                Console.WriteLine($"Average score: {averageMark:f2}");
                Console.WriteLine($"Number of problems: {problemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {poorGradesCounter} poor grades.");
            }
        }
    }
}


