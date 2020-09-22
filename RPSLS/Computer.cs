using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPSLS
{
    class Computer : Player
    {

        //member variables
        public string pick;


        //constructor
        public Computer()
        {
            name = "comPuter";
           
        }


        //member methods
        public override void ChooseGesture()
        {

            var random = new Random();
            var list = new List<string> { "rock", "paper", "scissor", "lizard", "spock" };
            int index = random.Next(list.Count);

            if(index == 0)
            {
                chosenGesture = "rock";
            }
            else if (index == 1)
            {
                 chosenGesture = "paper";
            }
            else if (index == 2)
            {
                 chosenGesture = "scissor";
            }
            else if (index == 3)
            {
                 chosenGesture = "lizard";
            }
            else if (index == 4)
            {
                 chosenGesture = "spock";
            }

        }
        
    }
}
