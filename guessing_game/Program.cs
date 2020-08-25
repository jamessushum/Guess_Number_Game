using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            AskQuestion();
        }

        static void AskQuestion()
        {
            int secretNum = 42;
            Console.Write("Guess the secret number: ");
            string answer = Console.ReadLine().ToLower();
            int stringToInt = Int32.Parse(answer);
            if (stringToInt == secretNum)
            {
                Console.Write("You're right!");
            }
            else
            {
                Console.Write("You're wrong!");
            }
        }
    }
}