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

            Console.Write("Select level of difficulty: easy, medium, hard: ");
            string levelAnswer = Console.ReadLine().ToLower();

            while (levelAnswer != "easy" && levelAnswer != "medium" && levelAnswer != "hard")
            {
                Console.Write("Select level of difficulty: easy, medium, hard: ");
                levelAnswer = Console.ReadLine().ToLower();
            }

            if (levelAnswer == "easy")
            {
                Console.WriteLine("Easy mode selected");
                EasyMode();
            }
            else if (levelAnswer == "medium")
            {
                Console.WriteLine("Medium mode selected");
                MediumMode();
            }
            else if (levelAnswer == "hard")
            {
                Console.WriteLine("Hard mode selected");
                HardMode();
            }
        }

        static void HardMode()
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
                if (answer < secretNum)
                {
                    Console.WriteLine("Guess is too Low!");
                }
                else if (answer > secretNum)
                {
                    Console.WriteLine("Guess is too High!");
                }

                while (tries < 4)
                {
                    Console.Write("Guess a number: ");
                    answer = Int32.Parse(Console.ReadLine());

                    if (answer != secretNum)
                    {
                        Console.WriteLine("Wrong guess!");
                        tries++;
                        Console.WriteLine($"Number of guesses left: {4 - tries}");
                        if (answer < secretNum)
                        {
                            Console.WriteLine("Guess is too Low!");
                        }
                        else if (answer > secretNum)
                        {
                            Console.WriteLine("Guess is too High!");
                        }
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

        static void MediumMode()
        {
            Console.Write("Guess a number (1-100): ");
            int answer = Int32.Parse(Console.ReadLine());
            int secretNum = new Random().Next(1, 100);
            int tries = 0;

            if (answer != secretNum)
            {
                Console.WriteLine("Wrong guess!");
                tries++;
                Console.WriteLine($"Number of guesses left: {6 - tries}");
                if (answer < secretNum)
                {
                    Console.WriteLine("Guess is too Low!");
                }
                else if (answer > secretNum)
                {
                    Console.WriteLine("Guess is too High!");
                }

                while (tries < 6)
                {
                    Console.Write("Guess a number: ");
                    answer = Int32.Parse(Console.ReadLine());

                    if (answer != secretNum)
                    {
                        Console.WriteLine("Wrong guess!");
                        tries++;
                        Console.WriteLine($"Number of guesses left: {6 - tries}");
                        if (answer < secretNum)
                        {
                            Console.WriteLine("Guess is too Low!");
                        }
                        else if (answer > secretNum)
                        {
                            Console.WriteLine("Guess is too High!");
                        }
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

        static void EasyMode()
        {
            Console.Write("Guess a number (1-100): ");
            int answer = Int32.Parse(Console.ReadLine());
            int secretNum = new Random().Next(1, 100);
            int tries = 0;

            if (answer != secretNum)
            {
                Console.WriteLine("Wrong guess!");
                tries++;
                Console.WriteLine($"Number of guesses left: {8 - tries}");
                if (answer < secretNum)
                {
                    Console.WriteLine("Guess is too Low!");
                }
                else if (answer > secretNum)
                {
                    Console.WriteLine("Guess is too High!");
                }

                while (tries < 8)
                {
                    Console.Write("Guess a number: ");
                    answer = Int32.Parse(Console.ReadLine());

                    if (answer != secretNum)
                    {
                        Console.WriteLine("Wrong guess!");
                        tries++;
                        Console.WriteLine($"Number of guesses left: {8 - tries}");
                        if (answer < secretNum)
                        {
                            Console.WriteLine("Guess is too Low!");
                        }
                        else if (answer > secretNum)
                        {
                            Console.WriteLine("Guess is too High!");
                        }
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