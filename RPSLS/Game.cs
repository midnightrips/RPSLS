using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
            Console.WriteLine("Rock crushes Scissors\nScissors cuts Paper \nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n");
            Console.WriteLine("Best of 3 wins!");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("Do you have 1 or 2 players?\n(Hint: enter either 1 or 2");
            string numberChosen = Console.ReadLine();
            while(numberChosen != "1" && numberChosen != "2")
            {
                Console.WriteLine("Please enter either '1' or '2':");
                numberChosen = Console.ReadLine();
            }
            int numberOfHumanPlayers = int.Parse(numberChosen);
            return numberOfHumanPlayers;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if(numberOfHumanPlayers == 1)
            {
                Console.WriteLine("What shall you be called?");
                string playerName = Console.ReadLine();
                playerOne = new HumanPlayer(playerName);
                playerTwo = new ComputerPlayer("CPU");
            }
            else if(numberOfHumanPlayers == 2)
            {
                Console.WriteLine("Player 1, what shall you be called?");
                string playerOneName = Console.ReadLine();
                playerOne = new HumanPlayer(playerOneName);

                Console.WriteLine("Player 2, what shall you be called?");
                string playerTwoName = Console.ReadLine();
                playerTwo = new HumanPlayer(playerTwoName);
            }
        }

        public void CompareGestures()
        {
            //while score is <2 for both players
            while(playerOne.score < 2 && playerTwo.score < 2)
            {
                Console.WriteLine($"{playerOne.name} chose {playerOne.chosenGesture}.");
                Console.WriteLine($"{playerTwo.name} chose {playerTwo.chosenGesture}.");
                if (playerOne.chosenGesture == playerTwo.chosenGesture)
                {
                    Console.WriteLine($"This round's a DRAW!\n\nThe score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine($"Paper covers Rock. {playerTwo.name} wins this round!\n\n");
                    playerTwo.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");                   
                }
                else if(playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine($"Rock crushes Scissors. {playerOne.name} wins this round!\n\n");
                    playerOne.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine($"Rock crushes Lizard. {playerOne.name} wins this round!\n\n");
                    playerOne.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine($"Spock vaporizes Rock. {playerTwo.name} wins this round!\n\n");
                    playerTwo.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine($"Paper covers Rock. {playerOne.name} wins this round!\n\n");
                    playerOne.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine($"Scissors cuts Paper. {playerTwo.name} wins this round!\n\n");
                    playerTwo.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine($"Lizard eats Paper. {playerTwo.name} wins this round!\n\n");
                    playerTwo.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine($"Paper disproves Spock. {playerOne.name} wins this round!\n\n");
                    playerOne.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine($"Rock crushes Scissors. {playerTwo.name} wins this round!\n\n");
                    playerTwo.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine($"Scissors cuts Paper. {playerOne.name} wins this round!\n\n");
                    playerOne.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine($"Scissors decapitates Lizard. {playerOne.name} wins this round!\n\n");
                    playerOne.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine($"Spock smashes Scissors. {playerTwo.name} wins this round!\n\n");
                    playerTwo.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine($"Rock crushes Lizard. {playerTwo.name} wins this round!\n\n");
                    playerTwo.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine($"Lizard eats Paper. {playerOne.name} wins this round!\n\n");
                    playerOne.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine($"Scissors decapitates Lizard. {playerTwo.name} wins this round!\n\n");
                    playerTwo.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine($"Lizard poisons Spock. {playerOne.name} wins this round!\n\n");
                    playerOne.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine($"Spock vaporizes Rock. {playerOne.name} wins this round!\n\n");
                    playerOne.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "paper" )
                {
                    Console.WriteLine($"Paper disproves Spock. {playerTwo.name} wins this round!\n\n");
                    playerTwo.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine($"Spock smashes Scissors. {playerOne.name} wins this round!\n\n");
                    playerOne.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
                else if(playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine($"Lizard poisons Spock. {playerTwo.name} wins this round!\n\n");
                    playerTwo.score++;
                    Console.WriteLine($"The score is ({playerOne.name}) {playerOne.score} to ({playerTwo.name}) {playerTwo.score}.\n");
                }
            }           
        }

        public void DisplayGameWinner()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine($"{playerOne.name} has won the game!");
            }
            else if(playerTwo.score == 2)
            {
                Console.WriteLine($"{playerTwo.name} has won the game!");
            }
            else
            {
                Console.WriteLine("there's a bug in the code 0.0");
            }
        }

        public void RunGame()
        {
            WelcomeMessage();
        }
    }
}
