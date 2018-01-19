using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Random Number Guessing Game");

            Boolean loopControl = true;
            Random randGen = new Random();

            while (loopControl)
            {
                System.Console.Write("\nEnter and Upper Boundry for the Numbers: ");
                string input = System.Console.ReadLine();
                int upperBound = int.Parse(input);

                int compNum = randGen.Next(1, upperBound);

                int guessCount = 0;

                System.Console.Write("\nEnter a Guess: ");
                input = System.Console.ReadLine();
                int userGuess = int.Parse(input);
                guessCount++;

                while(userGuess != compNum)
                {
                    if(userGuess < compNum)
                    {
                        System.Console.Write("Too Low, Try Again: ");
                        input = System.Console.ReadLine();
                        userGuess = int.Parse(input);
                        guessCount++;
                    }

                    else if(userGuess > compNum)
                    {
                        System.Console.Write("Too High, Try Again: ");
                        input = System.Console.ReadLine();
                        userGuess = int.Parse(input);
                        guessCount++;
                    }
                }

                System.Console.WriteLine("\nGood Work! You got it in " + guessCount + " guesses.");

                System.Console.Write("Play Again (y/n): ");
                String reLoop = System.Console.ReadLine();

                if(reLoop.Equals("y"))
                {
                    loopControl = true;
                }
                else
                {
                    loopControl = false;
                }
            }

            System.Console.WriteLine("\nThanks for Playing.");
            System.Console.WriteLine("Remeber to Tip Your Programmer");
            System.Console.WriteLine("©DSBD 2018, All Rights Reserved");

            System.Console.WriteLine("\nPress [ENTER] to Close Window");
            System.Console.ReadLine();
        }
    }
}
