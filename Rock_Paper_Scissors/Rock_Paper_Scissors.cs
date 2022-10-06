using System;

namespace Rock_Paper_Scissors
{
    internal class Rock_Paper_Scissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine();
            string choseNorY = string.Empty;

            const string yes = "yes";
            const string no = "no";

            int playerCounter = 0;
            int computerCounter = 0;
            int drawCount = 0;

            Console.ForegroundColor = ConsoleColor.Green;

            while (choseNorY != no)
            {

                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = Scissors;
                }
                else
                {
                    // if choose something else 

                    Console.WriteLine("Invalide Input. Try Again...");

                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
                    playerMove = Console.ReadLine();

                    continue;
                }

                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);

                string computerMove = string.Empty;
                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = "Rock";
                        break;
                    case 2:
                        computerMove = "Paper";
                        break;
                    case 3:
                        computerMove = "Scissors";
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"The computer chose {computerMove}");                              

                if ((playerMove == Rock && computerMove == Scissors) ||
                    (playerMove == Paper && computerMove == Rock) ||
                    (playerMove == Scissors && computerMove == Paper))

                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("You win.");
                    playerCounter++;
                }
                else if ((playerMove == Rock && computerMove == Paper) ||
                    (playerMove == Paper && computerMove == Scissors) ||
                    (playerMove == Scissors && computerMove == Rock))
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("You lose.");
                    computerCounter++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("The game was draw.");
                    
                    drawCount++;
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"Your wins: {playerCounter}");

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"Computer wins: {computerCounter}");

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"Game was draw: {drawCount}");
                Console.WriteLine();

                //If want to play again
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("Chose [Y]es to play again or [N]o to quit: ");
                choseNorY = Console.ReadLine();

                bool isPlayAgain = true;                

                if (choseNorY == "y" || choseNorY == "yes" || choseNorY == "Y" || choseNorY == "Yes")
                {
                    choseNorY = yes;
                    isPlayAgain = true;
                }
                else if (choseNorY == "n" || choseNorY == "no" || choseNorY == "N" || choseNorY =="No")
                {
                    choseNorY = no;
                    isPlayAgain = false;
                }
                else
                {
                    //if input is invalid (not y/n) - need to input Y/N
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Invalide input. Try again...Please chose y or n to continue..");

                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.WriteLine("Chose [Y]es to play again or [N]o to quit: ");
                    choseNorY = Console.ReadLine();
                }

                // if choose to play again or not

                if (isPlayAgain)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
                    playerMove = Console.ReadLine();
                }
                else
                {
                    break;
                }
                
            }
            int allCount = playerCounter + computerCounter + drawCount;

            if(playerCounter > computerCounter)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"From {allCount} games you won {playerCounter}. You win the game.");

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Thank you for playing!");

                Console.ForegroundColor = ConsoleColor.White;
            }
            else if(computerCounter > playerCounter)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"From {allCount} games computer won {computerCounter}. Computer win the game.");
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Thank you for playing!");

                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"From {allCount} games you won {playerCounter} , computer won {computerCounter} Nobody win. The game was draw.");

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Thank you for playing!");

                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
