namespace Hospital
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;
            int patientsSeen = 0;
            int patientsToOther = 0;
            int day = 1;
            for (int counter = 0; counter < period; counter++)
            {
                int patientsThisDay = int.Parse(Console.ReadLine());
                if (patientsThisDay <= doctors)
                {
                    patientsSeen += patientsThisDay;
                }
                else
                {
                    patientsToOther += (patientsThisDay - doctors);
                    patientsSeen += doctors;
                }

                if ((day + 1) % 3 == 0)
                {
                    if (patientsToOther > patientsSeen)
                    {
                        doctors++;
                    }
                }

                day++;
            }

            Console.WriteLine($"Treated patients: {patientsSeen}.");
            Console.WriteLine($"Untreated patients: {patientsToOther}.");
        }
    }
}
