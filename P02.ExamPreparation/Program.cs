using System;

namespace P02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failTimes = int.Parse(Console.ReadLine());

            string input;
            int evaluation;
            int evaluationCount = 0;
            int evaluationSum = 0;
            int failedCount = 0;
            string lastExercise = string.Empty;

            while ((input = Console.ReadLine()) != "Enough")
            {
                lastExercise = input;
                evaluation = int.Parse(Console.ReadLine());
                evaluationSum += evaluation;
                evaluationCount++;
                if (evaluation <= 4)
                {
                    failedCount++;
                    if (failedCount == failTimes)
                    {
                        Console.WriteLine($"You need a break, {failTimes} poor grades.");
                        break;
                    }
                }

            }
            if (input == "Enough")
                {
                    Console.WriteLine($"Average score: {(double)evaluationSum / evaluationCount:F2}");
                    Console.WriteLine($"Number of problems: {evaluationCount}");
                    Console.WriteLine($"Last problem: {lastExercise}");
                }

            
        }
    }
}
