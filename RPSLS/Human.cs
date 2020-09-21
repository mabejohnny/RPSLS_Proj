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
            Console.WriteLine("Here are your choices:" + "\n" + "\n");
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine(i);


            }
           
            Console.WriteLine("Choose your weapon!!!" + "\n" + "TYPE: '1' for 'rock' " + "\n" + "TYPE: '2' for 'paper' " + "\n" + "TYPE: '3' for 'scissors' " + "\n" + "TYPE: '4' for 'lizard' " + "\n" + "TYPE: '5' for 'spock' " + "\n" + "\n" + "* To return to the main menu, TYPE: '6' *");
            string choice = Console.ReadLine();

            switch (choice)   
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
                   MainMenu();
                    break;
                default:
                    Console.WriteLine("Error! Please try again");
                    ChooseGesture();
                    break;

            }
        }
    }
}
