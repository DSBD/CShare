using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IAD_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCore.Product gameProduct = new GameCore.Product();
            GameCore.Game currentGame = new GameCore.Game();

            Console.Write("Welcome to the Price is Right\nThe Game Where You Try and Guess the Price\nPress [ENTER] to Begin");
            Console.ReadLine();

            while(true)
            {
                gameProduct = currentGame.Start();

                Console.WriteLine("\nYou are guessing the price of " + gameProduct.Description);
                Console.WriteLine("The Maximum Price is $1000");
                int userGuess = getNumber("\nPlease Enter Your Guess: ");

                GameCore.Game.GuessStatus gameResult = currentGame.CheckGuess(userGuess);

                Boolean loopControl = true;

                while(loopControl)
                {
                    switch (gameResult)
                    {
                        case GameCore.Game.GuessStatus.TooLow:
                            userGuess = getNumber("Too Low, Try Again: ");
                            gameResult = currentGame.CheckGuess(userGuess);
                            break;
                        case GameCore.Game.GuessStatus.TooHigh:
                            userGuess = getNumber("Too High, Try Again: ");
                            gameResult = currentGame.CheckGuess(userGuess);
                            break;
                        case GameCore.Game.GuessStatus.Correct:
                            List<int> guessList = currentGame.getGuessList();

                            Console.WriteLine("\nThat's Correct");
                            Console.WriteLine("It took you " + currentGame.NumberOfTries + " guesses");
                            Console.Write("Your Guesses Were: ");
                            for (int i = 0; i < guessList.Count; i++)
                            {
                                Console.Write(guessList[i] + " ");
                            }
                            loopControl = false;
                            break;
                        default:
                            break;
                    }
                }

                Console.Write("\n\nPlay Again (y/n): ");
                String reLoop = Console.ReadLine();

                if (reLoop.Equals("y"))
                {
                    currentGame.resetStats();
                    continue;
                }
                else
                {
                    break;
                }
            }

            Console.Write("\nThanks for Playing, Press [ENTER] to Close Window");
            Console.ReadLine();
        }

        static int getNumber(string message)
        {
            int number;

            while (true)
            {
                try
                {
                    Console.Write(message);
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Input Error");
                }
            }
            return number;
        }
    }
}
