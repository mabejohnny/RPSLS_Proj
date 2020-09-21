using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPSLS
{
    class Computer : Player
    {

        //member variables
        


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

            Console.WriteLine("comPuter chose " + index);
            
        }
    }
}
