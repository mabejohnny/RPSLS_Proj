using System;
using System.Collections.Generic;
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
            Console.WriteLine("Choose your weapon!!!" + "\n" + "TYPE: '1' for 'rock' " + "\n" + "TYPE: '2' for 'paper' " + "\n" + "TYPE: '3' for 'scissors' " + "\n" + "TYPE: '4' for 'lizard' " + "\n" + "TYPE: '5' for 'spock' " + "\n" + "\n" + "* To return to the main menu, TYPE: '6' *");
            string gesture = Console.ReadLine();

            switch (gesture)   //how to choose from the list???
            {
                case "1":
                    
                    break;
                case "2":

                    break;
                case "3":

                    break;
                case "4":

                    break;
                case "5":

                    break;
                case "6":
                    //main menu???
                    break;
                default:
                    Console.WriteLine("Error! Please try again");
                    ChooseGesture();
                    break;

            }
        }
    }
}
