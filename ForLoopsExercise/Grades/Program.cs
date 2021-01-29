namespace Grades
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int failedStudents = 0;
            int averageStudents = 0;
            int goodStudents = 0;
            int topStudents = 0;
            double totalGradeExam = 0;
            for (int counter = 0; counter < students; counter++)
            {
                double currentStudentGrade = double.Parse(Console.ReadLine());
                totalGradeExam += currentStudentGrade;
                if (2 <= currentStudentGrade && currentStudentGrade <= 2.99)
                {
                    failedStudents++;
                }
                else if (3 <= currentStudentGrade && currentStudentGrade <= 3.99)
                {
                    averageStudents++;
                }
                else if (4 <= currentStudentGrade && currentStudentGrade <= 4.99)
                {
                    goodStudents++;
                }
                else
                {
                    topStudents++;
                }
            }

            Console.WriteLine($"Top students: {topStudents / (double)students * 100:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {goodStudents / (double)students * 100:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {averageStudents / (double)students * 100:F2}%");
            Console.WriteLine($"Fail: {failedStudents / (double)students * 100:F2}%");
            Console.WriteLine($"Average: {totalGradeExam / students:F2}");
        }
    }
}
