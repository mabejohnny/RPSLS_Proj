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
            Console.WriteLine("Choose your weapon!!!" + "\n" + "TYPE: '1' for 'Rock' " + "\n" + "TYPE: '2' for 'Paper' " + "\n" + "TYPE: '3' for 'Scissors' " + "\n" + "TYPE: '4' for 'Lizard' " + "\n" + "TYPE: '5' for 'Spock' " + "\n" + "\n" + "* To return to the main menu, TYPE: '6' *");
            string gesture = Console.ReadLine();

            switch (gesture)
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
                    RPSLS.
                    break;


                default:
                    break;

            }
        }
    }
}
