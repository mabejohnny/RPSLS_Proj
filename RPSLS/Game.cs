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
            MainMenu();
            while (playerOne.score < 3 && playerTwo.score < 3)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();

                CompareToFindRoundWinner();
            }

                CompareToFindGameWinner();

            
        }
        public void MainMenu()
        {
            Console.WriteLine("Welcome To The World Famous" + "\n" + "   Rock!" + "\n" + "      Paper!" + "\n" + "         Scissor!" + "\n" + "            Lizard!" + "\n" + "               Spock!" + "\n" + "\n");
            
            Console.WriteLine("Please choose from the following options:" + "\n" + "\n" + "- Type '1': For single player" + "\n" + "- Type '2': For multiplayer");
            string userInput = Console.ReadLine();
            Console.Clear();

            switch (userInput)
            {
                case "1":
                    playerOne = new Human();
                    playerTwo = new Computer();
                    DoubleCheckRightGameChoiceSinglePlayer();
                    SinglePlayerName();
                    break;
                case "2":
                    playerOne = new Human();
                    playerTwo = new Human();
                    DoubleCheckRightGameChoiceMultiPlayer();
                    MultiPlayerName();
                    break;

                default:
                    Console.WriteLine("Error! Please try again");
                    RunGame();
                    break;
            }
        }

        public void DoubleCheckRightGameChoiceSinglePlayer()
        {
            Console.WriteLine("You've chosen single-player mode, is that correct?" + "\n" + "\n" + "Type: '1' to continue" + "\n" + "Type: '2' to return to the main menu");
            string userAnswer = Console.ReadLine();

            switch (userAnswer)
            {
                case "1":
                    SinglePlayerName();
                    Console.Clear();
                    break;
                case "2":
                    MainMenu();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Error! Please try again");
                    DoubleCheckRightGameChoiceSinglePlayer();
                    Console.Clear();
                    break;

            }
        }

        public void DoubleCheckRightGameChoiceMultiPlayer()
        {
            Console.WriteLine("You've chosen multi-player mode, is that correct?" + "\n" + "\n" + "Type: '1' to continue" + "\n" + "Type: '2' to return to the main menu");
            string userAnswer = Console.ReadLine();

            switch (userAnswer)
            {
                case "1":
                    MultiPlayerName();
                    Console.Clear();
                    break;
                case "2":
                    MainMenu();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Error! Please try again");
                    DoubleCheckRightGameChoiceMultiPlayer();
                    Console.Clear();
                    break;

            }
        }

        public string SinglePlayerName()
        {
            Console.WriteLine("Please enter your name");
            playerOne.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Welcome to the game " + playerOne.name + "\n");
            ReadTheRulesSingle();
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
            Console.WriteLine("Allow me to introduce myself " + playerOne.name + ".  My name is " + playerTwo.name + ", and I will be beating you today!" + "\n" +"\n");
            Console.WriteLine("The rules are simple:" + "\n" + "- Each round will be worth 1 point" + "\n" + "- The first player to win best out of 3 wins!" + "\n" + "\n");
            Console.WriteLine("Rock crushes Scissors" + "\n" + "Scissors cuts Paper" + "\n" + "Paper covers Rock" + "\n" + "Rock crushes Lizard" + "\n" + "Lizard poisons Spock" + "\n" + "Spock Smashes Scissors" + "\n" + "Scissors decapitates Lizard" + "\n" + "Lizard eats Paper" + "\n" + "Paper disproves Spock" + "\n" + "Spock vaporizes Rock" + "\n" + "\n");
            Console.WriteLine("Hit 'enter' when your finished with the rules");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ohh, and one more this..." + "\n" + "                  comPuter beats " + playerOne.name + "!!!");
            Console.Clear();

        }

        public void ReadTheRulesMulti()
        {
            Console.WriteLine("Welcome to the game " + playerOne.name + " and " + playerTwo.name + "!!!" + "\n" + "\n");
            Console.WriteLine("The rules are simple:" + "\n" + "- Each round will be worth 1 point" + "\n" + "- The first player to win best out of 3 wins!" + "\n" +"\n");
            Console.WriteLine("Rock crushes Scissors" + "\n" + "Scissors cuts Paper" + "\n" + "Paper covers Rock" + "\n" + "Rock crushes Lizard" + "\n" + "Lizard poisons Spock" + "\n" + "Spock Smashes Scissors" + "\n" + "Scissors decapitates Lizard" + "\n" + "Lizard eats Paper" + "\n" + "Paper disproves Spock" + "\n" + "Spock vaporizes Rock");
            Console.WriteLine("Hit 'enter' when your finished with the rules");
            Console.ReadLine();
            Console.Clear();

        }

        public void CompareToFindRoundWinner()
        {
            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine(playerOne.name + " " + playerTwo.name +  " choose the same gesture! " + "\n" + "The result is a tie!");
            }
            else if (playerOne.chosenGesture == "rock")
            {
                if (playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine("paper covers rock..." + playerTwo.name + " wins this round!");
                    playerTwo.score++;
                }
                else if (playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine("rock crushes scissors..." + playerOne.name + " wins this round!");
                    playerOne.score++;
                }
                else if (playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine("rock crushes lizard..." + playerOne.name + " wins this round!");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine("spock vaporizes rock..." + playerTwo.name + " wins this round!");
                    playerTwo.score++;
                }
            }
            else if (playerOne.chosenGesture == "paper")
            {
                if (playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine("paper covers rock..." + playerOne.name + " wins this round!");
                    playerOne.score++;
                }
                else if (playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine("scissors cut paper..." + playerTwo.name + " wins this round!");
                    playerTwo.score++;
                }
                else if (playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine("lizard eats paper..." + playerTwo.name + " wins this round!");
                    playerTwo.score++;
                }
                else
                {
                    Console.WriteLine("paper disproves spock <br> You Win! :)");
                    playerTwo.score++;
                }
            }
            else if (playerOne.chosenGesture == "scissors")
            {
                if (playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine("rock crushes scissors..." + playerTwo.name + " wins this round!");
                    playerTwo.score++;
                }
                else if (playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine("scissors cut paper..." + playerOne.name + " wins this round!");
                    playerOne.score++;
                }
                else if (playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine("scissors decapitate lizard..." + playerOne.name + " wins this round!");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine("spock smashes scissors..." + playerTwo.name + " wins this round!");
                    playerTwo.score++;
                }
            }
            else if (playerOne.chosenGesture == "lizard")
            {
                if (playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine("rock crushes lizard..." + playerTwo.name + " wins this round!");
                    playerTwo.score++;
                }
                else if (playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine("lizard eats paper..." + playerOne.name + " wins this round!");
                    playerOne.score++;
                }
                else if (playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine("scissors decapitate lizard..." + playerTwo.name + " wins this round!");
                    playerTwo.score++;
                }
                else
                {
                    Console.WriteLine("lizard poisons spock..." + playerOne.name + " wins this round!");
                    playerOne.score++;
                }
            }
            else if (playerOne.chosenGesture == "spock")
            {
                if (playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine("spock vaporizes rock..." + playerOne.name + " wins this round!");
                    playerOne.score++;
                }
                else if (playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine("paper disproves spock..." + playerTwo.name + " wins this round!");
                    playerTwo.score++;
                }
                else if (playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine("spock smashes scissors..." + playerOne.name + " wins this round!");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine("lizard poisons spock..." + playerTwo.name + " wins this round!");
                    playerTwo.score++;
                }
            }
        }


        public void CompareToFindGameWinner()
        {
            if(playerOne.score > playerTwo.score)
            {
                Console.WriteLine(playerOne.name + " wins the game!!");
            }
            else if(playerOne.score < playerTwo.score)
            {
                Console.WriteLine(playerTwo.name + " wins the game!!");

            }

        }
    }  
}
