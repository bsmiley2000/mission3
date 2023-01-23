using System;
using System.Threading;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome user to the game
            Console.WriteLine("Welcome to a fantastic game of Tic Tac Toe!" + "\n");

            // Init the player's turn
            int player = 1;
          

            // Init our array of 9 positions
            string[] gameBoard = new string[10];

            bool gameOver = false;
            int userInput = 0;


            while (player < 10)
            {

                if (player % 2 == 0)
                {
                    Console.Write("Player 2 play: ");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    gameBoard[userInput] = "O";

                    player++;
                }


                else
                {
                    Console.Write("Player 1 play: ");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    gameBoard[userInput] = "X";

                    player++;
                }

            }

           // for (int i = 0; i < gameBoard.Length; i++ )
           // {
           //     Console.WriteLine(gameBoard[i]);
           // }


        }
    }
}
