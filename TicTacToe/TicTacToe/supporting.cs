using System;
using System.Collections.Generic;
using System.Text;

// Zach, Max, Brock, Katherine
// This program plays tic tac toe and does it between two classes
// this program allows the players to keep playing if even a winner has been declared

namespace TicTac
{
    class Supporting
    {
        // Method that prints the board along with the user choice
        public void PrintBoard(char[] BoardArray)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", BoardArray[1], BoardArray[2], BoardArray[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", BoardArray[4], BoardArray[5], BoardArray[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", BoardArray[7], BoardArray[8], BoardArray[9]);
            Console.WriteLine("     |     |      ");

        }

        // Method that declares the winner or if there is a draw
        public char DeclareWinner(char[] BoardArray)
        {
            char result = 'a';
           

            if ((BoardArray[1] == 'X') & (BoardArray[2] == 'X') & (BoardArray[3] == 'X'))
            {               
                Console.WriteLine("Player 2 Wins!");
            }
            else if ((BoardArray[1] == 'O') & (BoardArray[2] == 'O') & (BoardArray[3] == 'O'))
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else if ((BoardArray[4] == 'X') & (BoardArray[5] == 'X') & (BoardArray[6] == 'X'))
            {
                Console.WriteLine("Player 2 Wins!");
            }
            else if ((BoardArray[4] == 'O') & (BoardArray[5] == 'O') & (BoardArray[6] == 'O'))
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else if ((BoardArray[7] == 'X') & (BoardArray[8] == 'X') & (BoardArray[9] == 'X'))
            {
                Console.WriteLine("Player 2 Wins!");
            }
            else if ((BoardArray[7] == 'O') & (BoardArray[8] == 'O') & (BoardArray[9] == 'O'))
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else if ((BoardArray[1] == 'X') & (BoardArray[4] == 'X') & (BoardArray[7] == 'X'))
            {
                Console.WriteLine("Player 2 Wins!");
            }
            else if ((BoardArray[2] == 'O') & (BoardArray[4] == 'O') & (BoardArray[7] == 'O'))
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else if ((BoardArray[2] == 'X') & (BoardArray[5] == 'X') & (BoardArray[8] == 'X'))
            {
                Console.WriteLine("Player 2 Wins!");
            }
            else if ((BoardArray[2] == 'O') & (BoardArray[5] == 'O') & (BoardArray[8] == 'O'))
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else if ((BoardArray[3] == 'X') & (BoardArray[6] == 'X') & (BoardArray[9] == 'X'))
            {
                Console.WriteLine("Player 2 Wins!");
            }
            else if ((BoardArray[3] == 'O') & (BoardArray[6] == 'O') & (BoardArray[9] == 'O'))
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else if ((BoardArray[1] == 'X') & (BoardArray[5] == 'X') & (BoardArray[9] == 'X'))
            {
                Console.WriteLine("Player 2 Wins!");
            }
            else if ((BoardArray[1] == 'O') & (BoardArray[5] == 'O') & (BoardArray[9] == 'O'))
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else if ((BoardArray[3] == 'X') & (BoardArray[5] == 'X') & (BoardArray[7] == 'X'))
            {
                Console.WriteLine("Player 2 Wins!");
            }
            else if ((BoardArray[3] == 'O') & (BoardArray[5] == 'O') & (BoardArray[7] == 'O'))
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else if (BoardArray[1] != '1' && BoardArray[2] != '2' && BoardArray[3] != '3' && BoardArray[4] != '4' && BoardArray[5] != '5' && BoardArray[6] != '6' && BoardArray[7] != '7' && BoardArray[8] != '8' && BoardArray[9] != '9')
            {
                Console.WriteLine("Looks like it's a CAT!");
            }
            else
            {
                result = 'a';
            }

            return result;
        }
    }
}
