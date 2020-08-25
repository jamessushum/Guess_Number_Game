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

            Console.Write("Select level of difficulty: Easy, Medium, Hard, Cheater: ");
            string levelAnswer = Console.ReadLine().ToLower();

            while (levelAnswer != "easy" && levelAnswer != "medium" && levelAnswer != "hard" && levelAnswer != "cheater")
            {
                Console.Write("Select level of difficulty: Easy, Medium, Hard, Cheater: ");
                levelAnswer = Console.ReadLine().ToLower();
            }

            if (levelAnswer == "easy")
            {
                Console.WriteLine("Easy mode selected.");
                int numOfTriesEasy = 8;
                Mode(numOfTriesEasy);
                // EasyMode();
            }
            else if (levelAnswer == "medium")
            {
                Console.WriteLine("Medium mode selected.");
                int numOfTriesMedium = 6;
                Mode(numOfTriesMedium);
                // MediumMode();
            }
            else if (levelAnswer == "hard")
            {
                Console.WriteLine("Hard mode selected.");
                int numOfTriesHard = 4;
                Mode(numOfTriesHard);
                // HardMode();
            }
            else if (levelAnswer == "cheater")
            {
                Console.WriteLine("Cheater mode selected.");
                CheaterMode();
            }
        }

        static void CheaterMode()
        {
            Console.Write("Pick a number (1-100): ");
            int answer = Int32.Parse(Console.ReadLine());
            int secretNum = new Random().Next(1, 100);

            if (answer != secretNum)
            {
                Console.WriteLine("Wrong guess!");
                if (answer < secretNum)
                {
                    Console.WriteLine("Too Low!");
                }
                else if (answer > secretNum)
                {
                    Console.WriteLine("Too High!");
                }

                while (answer != secretNum)
                {
                    Console.Write("Pick another number: ");
                    answer = Int32.Parse(Console.ReadLine());

                    if (answer != secretNum)
                    {
                        Console.WriteLine("Wrong guess!");
                        if (answer < secretNum)
                        {
                            Console.WriteLine("Too Low!");
                        }
                        else if (answer > secretNum)
                        {
                            Console.WriteLine("Too High!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Winner Winner Chicken Dinner!");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
            }
        }

        static void Mode(int numOfTries)
        {
            Console.Write("Pick a number (1-100): ");
            int answer = Int32.Parse(Console.ReadLine());
            int secretNum = new Random().Next(1, 100);
            int tries = 0;

            if (answer != secretNum)
            {
                Console.WriteLine("Wrong guess!");
                tries++;
                Console.WriteLine($"Number of guesses left: {numOfTries - tries}");
                if (answer < secretNum)
                {
                    Console.WriteLine("Too Low!");
                }
                else if (answer > secretNum)
                {
                    Console.WriteLine("Too High!");
                }

                while (tries < numOfTries)
                {
                    Console.Write("Pick another number: ");
                    answer = Int32.Parse(Console.ReadLine());

                    if (answer != secretNum)
                    {
                        Console.WriteLine("Wrong guess!");
                        tries++;
                        Console.WriteLine($"Number of guesses left: {numOfTries - tries}");
                        if (answer < secretNum)
                        {
                            Console.WriteLine("Too Low!");
                        }
                        else if (answer > secretNum)
                        {
                            Console.WriteLine("Too High!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Winner Winner Chicken Dinner!");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
            }
        }
    }
}