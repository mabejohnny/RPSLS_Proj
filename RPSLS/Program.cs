using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            //main menu where user can see the rules and choose single/multiplayer game

            //multiplayer:
            //method for rules
            //method for multiplayer (switchCase) where both users can choose a gesture from a list 
            //method to compare 2 gestures, determine a winner, add to counter
            //notify players who one the round
            //compare in if/else statment whether a user has gotten best out of three
            //ask player if they want to play again or exit

            //single player:
            //Rules
            //method for computer to be assigned a random gesture (method only for computer)
            //method to compare 2 gestures, determine a winner, add to counter (method for both player1 and player 2 regardless of single/multiplayer)
            //notify players who one the round
            //compare in if/else statment whether a user has gotten best out of three
            //ask player if they want to play again or exit

            Game game = new Game();
            game.RunGame();
        }
    }
}
