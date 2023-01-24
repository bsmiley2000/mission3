using System;
using System.Threading;
using TicTac;


namespace TicTac
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Init the player's turn
            int player = 1;

            // Init our array of 9 positions
            char[] gameBoard = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            bool gameOver = false;
            int userInput = 0;

            Supporting s = new Supporting();

            

            while (player < 10)
            {

                // Welcome user to the game
                Console.WriteLine("Welcome to a fantastic game of Tic Tac Toe!" + "\n");

                s.PrintBoard(gameBoard);

                if (player % 2 == 0)
                {
                    Console.Write("Player 2 play: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    gameBoard[userInput] = Convert.ToChar("X");
                    player++;
                }
                else
                {
                    Console.Write("Player 1 play: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    gameBoard[userInput] = Convert.ToChar("O");
                    player++;
                }

                s.PrintBoard(gameBoard);

                char winner = s.DeclareWinner(gameBoard);

                Console.Clear();

              //  if (winner == 'D')
             //   {
              //      Console.WriteLine("CAT");
               // }
             
            }



            
        }
    }
}