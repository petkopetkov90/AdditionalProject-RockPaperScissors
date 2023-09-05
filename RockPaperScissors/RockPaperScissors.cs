using System;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.ForegroundColor = ConsoleColor.Cyan;
            string playerChoose = string.Empty;

            bool endGame = false;

            int playerScore = 0;
            int computerScore = 0;
            int drawGamens = 0;

            while (!endGame)
            {
                while (!endGame)
                {
                    Console.Write("Choose one of: [r]ock, [p]aper or [s]cissors: ");
                    playerChoose = Console.ReadLine().ToLower();

                    if (playerChoose == "r" || playerChoose == "rock")
                    {
                        playerChoose = Rock;
                        break;
                    }
                    else if (playerChoose == "p" || playerChoose == "paper")
                    {
                        playerChoose = Paper;
                        break;
                    }
                    else if (playerChoose == "s" || playerChoose == "scissors")
                    {
                        playerChoose = Scissors;
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid input. Please choose again: ");
                    }
                }
                Console.ResetColor();

                Random randomNumber = new Random();
                int computerRandomNumber = randomNumber.Next(1, 4);
                string computerChoose = string.Empty;

                switch (computerRandomNumber)
                {
                    case 1:
                        computerChoose = Rock;
                        break;
                    case 2:
                        computerChoose = Paper;
                        break;
                    case 3:
                        computerChoose = Scissors;
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"You choose {playerChoose}");
                Console.WriteLine($"Computer choose {computerChoose}");
                Console.ResetColor();

                if (playerChoose == computerChoose)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("This game was a draw.");
                    drawGamens++;
                }
                else if ((playerChoose == Rock && computerChoose == Scissors) || (playerChoose == Paper && computerChoose == Rock) || (playerChoose == Scissors && computerChoose == Paper))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win.");
                    playerScore++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose.");
                    computerScore++;
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Type [y]es to play again or [n]o to quit: ");
                string type = Console.ReadLine().ToLower();

                while (!endGame)
                {
                    if (type == "y" || type == "yes")
                    {
                        break;
                    }
                    else if (type == "n" || type == "no")
                    {
                        endGame = true;
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid input. Please try again: ");
                        type = Console.ReadLine().ToLower();
                    }
                }
            }
            Console.WriteLine("You choose to quit.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your score is {playerScore}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Computer score is {computerScore}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Draw games {drawGamens}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Thank you for playing!");
        }
    }
}