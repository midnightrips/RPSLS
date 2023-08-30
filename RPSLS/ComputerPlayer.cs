using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class ComputerPlayer : Player
    {
        Random rand;
        public ComputerPlayer(string name) : base(name)
        {
            rand = new Random();
        }

        public override void ChooseGesture()
        {
            int gestureIndex = rand.Next(gestures.Count);
            chosenGesture = gestures[gestureIndex];
        }
    }
}
