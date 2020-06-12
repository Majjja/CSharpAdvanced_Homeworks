using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Create a console application that plays rock -paper - scissors
            //There should be a menu with three options:
            //  Play
            //      a. The user picks rock paper or scissors option
            //      b. The application picks rock paper scissors on random
            //      c. The user pick and the application pick are shown on the screen
            //      d. The application shows the winner
            //      e. The application saves 1 score to the user or the computer in the background
            //      f. When the user hits enter it returns to the main menu
            //  Stats
            //      a. It shows how many wins the user and how many wins the computer has
            //      b. It shows percentage of the wins and loses of the user
            //      c. When the user hits enter it returns to the main menu
            //  Exit
            //      a. It closes the application
            #endregion



            var options = new List<string>() { "rock", "paper", "scissors" };

            int score = 0;
            int computerScore = 0;
            while (true)
            {
                Console.WriteLine(@"Pick: ""Rock"", ""Paper"", ""Scissors""");
                string userInput;


                userInput = Console.ReadLine().ToLower();
                if (userInput == "exit")
                {
                    break;
                }
                var contains = options.FirstOrDefault(input => input.Equals(userInput));
                if (contains == null)
                {
                    Console.WriteLine("You entered an invalid input try again");
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Your pick: ***{contains}***");
                Console.ResetColor();



                var random = new Random().Next(options.Count);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Computer pick: ***{options[random]}***");
                Console.ResetColor();

                if (userInput.Equals(options[random]))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("No winner, try agayn :/");
                    Console.ResetColor();
                    continue;
                }
                if (userInput.Equals("rock") && options[random].Equals("scissors")
                    || userInput.Equals("scissors") && options[random].Equals("paper")
                    || userInput.Equals("paper") && options[random].Equals("rock"))
                {
                    score++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win :)))");
                    Console.ResetColor();
                }
                if (userInput.Equals("scissors") && options[random].Equals("rock")
                    || userInput.Equals("paper") && options[random].Equals("scissors")
                    || userInput.Equals("rock") && options[random].Equals("paper"))
                {
                    computerScore++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose :((");
                    Console.ResetColor();
                }
            }

            if (score > computerScore)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("CONGRATULATIONS!!! You are the WINNER :)))");
                Console.WriteLine($"Your score: {score}\nComputer score: {computerScore}");
                Console.WriteLine("{0}: {1:0.00}%, {2}: {3:0.00}%",
                    "Percent of your win", PercetnageOfWinsAndLoses(score, computerScore),
                    "Percent of your lose", (100 - PercetnageOfWinsAndLoses(score, computerScore)));
                Console.ResetColor();

            }
            else if (score == computerScore)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("There is no winner");
                Console.WriteLine($"Your score: {score}\nComputer score: {computerScore}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, you lost the game :(");
                Console.WriteLine($"Your score: {score}\nComputer score: {computerScore}");
                Console.WriteLine("{0}: {1: 0.00}%, {2}: {3:0.00}%",
                    "Percent of your win", PercetnageOfWinsAndLoses(score, computerScore),
                    "Percent of your lose", 100 - PercetnageOfWinsAndLoses(score, computerScore));
                Console.ResetColor();
            }
        }
        public static decimal PercetnageOfWinsAndLoses(int user_score, int comp_score)
        {
            decimal user = Convert.ToDecimal(user_score);
            decimal comp = Convert.ToDecimal(comp_score);

            decimal scores = user / (user + comp);
            decimal percentage = scores * 100;
            return percentage;
        }
    }
}
