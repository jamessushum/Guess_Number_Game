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
            Console.Write("Guess a number (1-100): ");
            int answer = Int32.Parse(Console.ReadLine());
            int secretNum = new Random().Next(1, 100);
            int tries = 0;

            if (answer != secretNum)
            {
                Console.WriteLine("Wrong guess!");
                tries++;
                Console.WriteLine($"Number of guesses left: {4 - tries}");

                while (tries < 4)
                {
                    Console.Write("Guess a number: ");
                    answer = Int32.Parse(Console.ReadLine());

                    if (answer != secretNum)
                    {
                        Console.WriteLine("Wrong guess!");
                        tries++;
                        Console.WriteLine($"Number of guesses left: {4 - tries}");
                    }
                    else
                    {
                        Console.WriteLine("Your guess is right!");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("You're correct!");
            }
        }
    }
}