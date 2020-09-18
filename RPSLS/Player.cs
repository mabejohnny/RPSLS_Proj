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
        public string choice;

        



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
        public void ChooseGesture()
        {
            Console.WriteLine("Choose your weapon!!!" + "\n" + "TYPE: '1' for 'rock' " + "\n" + "TYPE: '2' for 'paper' " + "\n" + "TYPE: '3' for 'scissors' " + "\n" + "TYPE: '4' for 'lizard' " + "\n" + "TYPE: '5' for 'spock' " + "\n" + "\n" + "* To return to the main menu, TYPE: '6' *");
            string gesture = Console.ReadLine();

            switch (gesture)
            {
                case "1":
                    "rock";
                    break;
                default:
                    break;
            }
        }
    }
}
