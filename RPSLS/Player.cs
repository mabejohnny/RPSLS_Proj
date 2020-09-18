using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Player
    {

        //member variables
        public List<Gestures> gestures;

        public string name;
        public int score;

        



        //constructor
        public Player()
        {
            gestures = new List<Gestures>();
            gestures.Add(new Gestures("Rock"));
            gestures.Add(new Gestures("Paper"));
            gestures.Add(new Gestures("Scissor"));
            gestures.Add(new Gestures("Lizard"));
            gestures.Add(new Gestures("Spock"));

            
            this.score = 0; 




        }




        //member methods

    }
}
