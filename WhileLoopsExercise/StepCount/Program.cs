namespace StepCount
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int totalSteps = 0;
            bool isReached = false;
            bool isGoingHome = false;
            while (!isGoingHome && !isReached)
            {
                string input = Console.ReadLine();
                int currentSteps = 0;
                if (input == "Going home")
                {
                    isGoingHome = true;
                    currentSteps = int.Parse(Console.ReadLine());
                }
                else
                {
                    currentSteps = int.Parse(input);
                }

                totalSteps += currentSteps;
                if (totalSteps >= goal)
                {
                    isReached = true;
                }
            }

            if (isReached)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{goal - totalSteps} more steps to reach goal.");
            }
        }
    }
}
