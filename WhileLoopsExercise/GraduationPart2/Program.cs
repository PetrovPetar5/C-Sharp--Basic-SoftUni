namespace GraduationPart2
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int gradeCounter = 1;
            double totalGrade = 0;
            bool excluded = false;
            int failsCounter = 0;
            while (gradeCounter <= 12)
            {
                if (failsCounter > 1)
                {
                    excluded = true;
                }

                if (excluded)
                {
                    Console.WriteLine("{0} has been excluded at {1} grade", studentName, gradeCounter);
                    break;
                }

                double currentGrade = double.Parse(Console.ReadLine());
                if (currentGrade >= 4)
                {
                    totalGrade += currentGrade;
                    gradeCounter++;
                }
                else
                {
                    failsCounter++;
                }
            }
            if (!excluded)
            {
                double averageGrade = totalGrade / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
