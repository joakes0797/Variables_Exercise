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
            bool isCool = true;
            double myScore = 97.26;
            decimal myQuiz = 21.654321m;

            Console.WriteLine($"Four {timeLine} {timeYears} years ago {timeLetter} {isCool}Coder student scored {myScore} percent on {myQuiz} quizzes.");
        }
    }
}
