using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] BoardArray = new char[] {' ',' ',' ',' ',' ',' ',' ',' ',' '};
            Console.WriteLine("Hello World!");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", BoardArray[0], BoardArray[1], BoardArray[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", BoardArray[3], BoardArray[4], BoardArray[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", BoardArray[6], BoardArray[7], BoardArray[8]);
            Console.WriteLine("     |     |      ");

        }
    }
}
