using System;
using System.Collections.Generic;
using System.Text;

namespace TicTac
{
    class Supporting
    {
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
        public char DeclareWinner(char[] BoardArray)
        {
           char result = 'D';
           if ((BoardArray[0] == 'X') & (BoardArray[1] == 'X') & (BoardArray[2] == 'X'))
            {
                result = 'X';
                Console.WriteLine("Player 1 wins!");

            }
            else if ((BoardArray[0] == 'O') & (BoardArray[1] == 'O') & (BoardArray[2] == 'O'))
            {
                result = 'O';
            }
            else if ((BoardArray[3] == 'X') & (BoardArray[4] == 'X') & (BoardArray[5] == 'X'))
            {
                result = 'X';
            }
            else if ((BoardArray[3] == 'O') & (BoardArray[4] == 'O') & (BoardArray[5] == 'O'))
            {
                result = 'O';
            }
            else if ((BoardArray[6] == 'X') & (BoardArray[7] == 'X') & (BoardArray[8] == 'X'))
            {
                result = 'X';
            }
            else if ((BoardArray[6] == 'O') & (BoardArray[7] == 'O') & (BoardArray[8] == 'O'))
            {
                result = 'O';
            }
            else if ((BoardArray[0] == 'X') & (BoardArray[3] == 'X') & (BoardArray[6] == 'X'))
            {
                result = 'X';
            }
            else if ((BoardArray[0] == 'O') & (BoardArray[3] == 'O') & (BoardArray[6] == 'O'))
            {
                result = 'O';
            }
            else if ((BoardArray[1] == 'X') & (BoardArray[4] == 'X') & (BoardArray[7] == 'X'))
            {
                result = 'X';
            }
            else if ((BoardArray[1] == 'O') & (BoardArray[4] == 'O') & (BoardArray[7] == 'O'))
            {
                result = 'O';
            }
            else if ((BoardArray[2] == 'X') & (BoardArray[5] == 'X') & (BoardArray[8] == 'X'))
            {
                result = 'X';
            }
            else if ((BoardArray[2] == 'O') & (BoardArray[5] == 'O') & (BoardArray[8] == 'O'))
            {
                result = 'O';
            }
            else if ((BoardArray[0] == 'X') & (BoardArray[4] == 'X') & (BoardArray[8] == 'X'))
            {
                result = 'X';
            }
            else if ((BoardArray[0] == 'O') & (BoardArray[4] == 'O') & (BoardArray[8] == 'O'))
            {
                result = 'O';
            }
            else if ((BoardArray[2] == 'X') & (BoardArray[4] == 'X') & (BoardArray[6] == 'X'))
            {
                result = 'X';
            }
            else if ((BoardArray[2] == 'O') & (BoardArray[4] == 'O') & (BoardArray[6] == 'O'))
            {
                result = 'O';
            }
            
            return result;
        }
    }
}
