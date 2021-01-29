namespace Graduation
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int counter = 0;
            double totalGradeSum = 0;
            while (counter < 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());
                if (currentGrade < 4)
                {
                    continue;
                }

                totalGradeSum += currentGrade;
                counter++;
            }

            double averageGrade = totalGradeSum / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
        }
    }
}
