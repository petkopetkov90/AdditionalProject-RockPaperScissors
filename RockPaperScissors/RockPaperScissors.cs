using System;
using System.ComponentModel;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.Write("Choose one of: [r]ock, [p]aper or [s]cissors: ");
            string playerChoose = string.Empty;

            while (true)
            {
                playerChoose = Console.ReadLine();

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

            Console.WriteLine($"You choose {playerChoose}");
            Console.WriteLine($"Computer choose {computerChoose}");

            if (playerChoose == computerChoose)
            {
                Console.WriteLine("This game was a draw.");
            }
            else if ((playerChoose == Rock && computerChoose == Scissors) || (playerChoose == Paper && computerChoose == Rock) || (playerChoose == Scissors && computerChoose == Paper))
            {
                Console.WriteLine("You win.");
            }
            else
            {
                Console.WriteLine("You lose.");
            }
        }
    }
}