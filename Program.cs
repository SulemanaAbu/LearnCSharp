using System;

namespace MyFirstProgram
{
    class Program
    {
        // rock paper scissors game 
        static void Main(string[] args)
        {
            Console.ReadKey();
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String response;

            while (playAgain)
            {
                player = "";
                computer = "";
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS" )
                {
                    Console.WriteLine("Enter ROCK, PAPER or SCISSORS");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                int randomNum = random.Next(1, 4);
                switch (randomNum)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player: "+player);
                Console.WriteLine("Computer: "+computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a DRAW!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose");
                        }
                        else
                        {
                            Console.WriteLine("You WIN!!");
                        }
                        
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You WIN!!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a DRAW!!");
                        }
                        else
                        {
                            Console.WriteLine("You lose!!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You WIN!!");
                        }
                        else
                        {
                            Console.WriteLine("It's a DRAW!!");
                        }
                        break;
                }

                Console.WriteLine("Would you like to play again? (Y/N)");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else 
                {
                    playAgain = false;
                }
                
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}