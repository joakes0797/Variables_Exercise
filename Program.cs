using System;

namespace Variables_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string timeLine = "score and";
            int timeYears = 7;
            char timeLetter = 'a';
            bool isAlive = true;
            double myScore = 99.99;
            decimal myAge = 21.6543m;

            Console.WriteLine($"Four {timeLine} {timeYears} years ago {timeLetter} {isAlive}Coder student scored {myScore} percent on {myAge} quizzes.");
        }
    }
}
