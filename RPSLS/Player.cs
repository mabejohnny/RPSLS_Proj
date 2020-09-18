using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    abstract class Player
    {

        //member variables
        public List<string> gestures;

        public string name;
        public int score;
        public string choice;

        



        //constructor
        public Player()
        {
            gestures = new List<string> { "rock", "paper", "scissor", "lizard", "spock" };
        
            this.score = 0; 

        }




        //member methods
        public abstract void ChooseGesture();




    }
}
