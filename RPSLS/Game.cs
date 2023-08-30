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

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
        }
    }
}
