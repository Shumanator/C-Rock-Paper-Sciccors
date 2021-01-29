using System;

namespace Rock_Paper_Sciccors
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerInput, computerInput;
            int randomNum; 
            Boolean playAgain = true;


            while (playAgain)
            {

                int playerScore = 0;
                int computerScore = 0;



                while (playerScore < 3 && computerScore < 3)
                {
                    Console.WriteLine("Please Choose ROCK, PAPER or SCICCORS:");
                    playerInput = Console.ReadLine();
                    playerInput = playerInput.ToUpper();


                    Random random = new Random();

                    randomNum = random.Next(1, 4);

                    switch (randomNum)
                    {
                        case 1:
                            computerInput = "ROCK";
                            if (playerInput == "")
                            {

                            }
                            else
                            {

                            }

                            if (playerInput == "ROCK")
                            {
                                Console.WriteLine("Draw\n\n");
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("You Win\n\n");
                                playerScore++;

                            }
                            else if (playerInput == "SCICCORS")
                            {
                                Console.WriteLine("Computer Wins\n\n");
                                computerScore++;
                            }
                            else if (playerInput == "")
                            {
                                Console.WriteLine("You must enter a valid answer\n\n");
                            }
                            break;
                        case 2:
                            computerInput = "PAPER";
                            if (playerInput == "")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Computer chose PAPER");
                            }

                            if (playerInput == "ROCK")
                            {
                                Console.WriteLine("Computer Wins\n\n");
                                computerScore++;
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("Draw\n\n");

                            }
                            else if (playerInput == "SCICCORS")
                            {
                                Console.WriteLine("You Win\n\n");
                                playerScore++;
                            }
                            else if (playerInput == "")
                            {
                                Console.WriteLine("You must enter a valid answer\n\n");
                            }
                            break;
                        case 3:
                            computerInput = "SCICCORS";
                            if (playerInput == "")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Computer chose SCICCORS");
                            }
                            if (playerInput == "ROCK")
                            {
                                Console.WriteLine("You Win\n\n");
                                playerScore++;
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("Computer Wins\n\n");
                                computerScore++;

                            }
                            else if (playerInput == "SCICCORS")
                            {
                                Console.WriteLine("Draw\n\n");
                            }
                            else if (playerInput == "")
                            {
                                Console.WriteLine("You must enter a valid answer\n\n");
                            }
                            break;
                        default:
                            break;

                    }




                    if (playerInput == "")
                    {

                    }
                    else
                    {
                        Console.WriteLine("\nSCORES:\tPLAYER:{0}\tCOMPUTER:{1}\n", playerScore, computerScore);
                    }


                    if (playerScore == 3)
                    {
                        Console.WriteLine("Player Wins\n\n");

                    }
                    else if (computerScore == 3)
                    {
                        Console.WriteLine("Computer Wins\n\n");
                    }

                    

                }

                Console.WriteLine("Do you want to play again ? [y]/[n]");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();

                }
                else if (loop == "n")
                {
                    playAgain = false;
                }


            }

        }
    }
}
