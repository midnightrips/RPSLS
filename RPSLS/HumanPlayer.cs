using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer : Player
    {
        //member variables
        
        //constructor
        public HumanPlayer(string name) : base(name)
        {
        }

        //member methods
        public override void ChooseGesture()
        {
            throw new NotImplementedException();
            Console.WriteLine("Choose one of the following:\n");
            Console.WriteLine("Rock\nPaper\nScissors\nLizard\nLizard\nSpock");
            string choosingGesture = Console.ReadLine();
            chosenGesture = choosingGesture.ToLower();
            
            while(chosenGesture != "rock" || chosenGesture != "paper" || chosenGesture != "scissors" || chosenGesture != "lizard" || chosenGesture != "spock") //there's gotta be a simplified way of doing this via comparison to the list gestures
            {
                Console.WriteLine($"{choosingGesture} is not an option. Please choose from the following options:\nRock\nPaper\nScissors\nLizard\nLizard\nSpock");
                choosingGesture = Console.ReadLine();
                chosenGesture = choosingGesture.ToLower();
            }
        }
    }
}
