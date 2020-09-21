using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPSLS
{
    class Human : Player
    {

        //member variables



        //constructor
        public Human()
        {

        }




        //member methods
        public override void ChooseGesture()
        {

            int counter = 0;
            foreach (string type in gestures)
            {
                Console.WriteLine(counter++ + type);
                string choice = Console.ReadLine();
            }


                Console.WriteLine("Type the number of your choice:");
                
                string chosenGesture = Console.ReadLine();

                switch (chosenGesture)
                {
                    case "1":
                        chosenGesture = gestures[0];
                        break;
                    case "paper":
                        chosenGesture = gestures[1];
                        break;
                    case "scissor":
                        chosenGesture = gestures[2];
                        break;
                    case "lizard":
                        chosenGesture = gestures[3];
                        break;
                    case "spock":
                        chosenGesture = gestures[4];
                        break;
                    default:
                        Console.WriteLine("Error! Please try again");
                        break;

                }
            
        }
    }

}

