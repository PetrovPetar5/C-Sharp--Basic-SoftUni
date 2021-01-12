namespace ExcellentGrade
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double examGrade = double.Parse(Console.ReadLine());
            if (examGrade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
