using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {

        //member variables
        Player playerOne;
        Player playerTwo;
        


        //constructor
        public Game()
        {

        }




        //member methods
        public void RunGame()
        {
        }


        public void MainMenu()
        {
            Console.WriteLine("Welcome To The World Famous" + "\n" + "   Rock!" + "\n" + "      Paper!" + "\n" + "         Scissor!" + "\n" + "            Lizard!" + "\n" + "               Spock!");
            Console.Clear();
            Console.WriteLine("Please choose from the following options:" + "\n" + "\n" + "- Type '1': For single player" + "\n" + "- Type '2': For multiplayer");
            string userInput = Console.ReadLine();
            Console.Clear();

            switch (userInput)
            {
                case "1":
                    playerOne = new Human();
                    playerTwo = new Computer("comPuter");
                    SinglePlayerName();
                    break;
                case "2":
                    playerOne = new Human();
                    playerTwo = new Human();
                    MultiPlayerName();
                    break;

                default:
                    Console.WriteLine("Error! Please try again");
                    RunGame();
                    break;
            }

        }

        public string SinglePlayerName()
        {
            Console.WriteLine("Please enter your name");
            playerOne.name = Console.ReadLine();
            Console.WriteLine("Welcome to the game " + playerOne.name);
            this.ReadTheRulesSingle();
            return playerOne.name;
        }

        public string MultiPlayerName()
        {
            Console.WriteLine("Please enter name for player one:");
            playerOne.name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please enter name for player two:");
            playerTwo.name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Welcome To The Battle Royal!" + "\n" + "\n" + playerOne.name + " VS. " + playerTwo.name);
            this.ReadTheRulesMulti();

            return playerOne.name + playerTwo.name; 
            


        }


        public void ReadTheRulesSingle()
        {
            Console.WriteLine("Welcome to your own personal HELL " + playerOne.name + "!" + "\n" + "\n");
            Console.WriteLine("The rules are simple:" + "\n" + "- Each round will be worth 1 point" + "\n" + "- The first player to win best out of 3 wins!");
            Console.WriteLine("Rock crushes Scissors" + "\n" + "Scissors cuts Paper" + "\n" + "Paper covers Rock" + "\n" +"Rock crushes Lizard" +"\n" + "Lizard poisons Spock" + "\n" + "Spock Smashes Scissors" +"\n" + "Scissors decapitates Lizard" +"\n" +"Lizard eats Paper" +"\n" +"Paper disproves Spock" +"\n" +"Spock vaporizes Rock");
            Console.WriteLine("Hit 'enter' when your finished with the rules");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ohh, and one more this..." + "\n" + "                  comPuter beats " + playerOne.name + "!!!");
            Console.Clear();

        }

        public void ReadTheRulesMulti()
        {
            Console.WriteLine("Welcome to the game " + playerOne.name + " " + playerTwo.name + "!!!");
            Console.WriteLine("The rules are simple:" + "\n" + "- Each round will be worth 1 point" + "\n" + "- The first player to win best out of 3 wins!");
            Console.WriteLine("Rock crushes Scissors" + "\n" + "Scissors cuts Paper" + "\n" + "Paper covers Rock" + "\n" + "Rock crushes Lizard" + "\n" + "Lizard poisons Spock" + "\n" + "Spock Smashes Scissors" + "\n" + "Scissors decapitates Lizard" + "\n" + "Lizard eats Paper" + "\n" + "Paper disproves Spock" + "\n" + "Spock vaporizes Rock");
            Console.WriteLine("Hit 'enter' when your finished with the rules");
            Console.ReadLine();
            Console.Clear();
            

        }











    }
}
