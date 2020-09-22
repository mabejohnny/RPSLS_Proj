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

            int counter = 1;
            foreach (string type in gestures)
            {
                Console.WriteLine(counter++ + " : " + type);
               
            }


                Console.WriteLine("Type the number of your choice:");
                
                chosenGesture = Console.ReadLine();

                switch (chosenGesture)
                {
                    case "1":
                        chosenGesture = gestures[0];
                    break;
                    case "2":
                        chosenGesture = gestures[1];
                    break;
                    case "3":
                        chosenGesture = gestures[2];
                    break;
                    case "4":
                        chosenGesture = gestures[3];
                    break;
                    case "5":
                        chosenGesture = gestures[4];
                        break;
                    default:
                        Console.WriteLine("Error! Please try again");
                        break;

                }
            
            
        }
    }

}

