using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to group 2-6's Tic-Tac-Toe Game!");

            byte[] gameBoard = new byte[9];

            //for(int i = 0; i < 9; i++)
            //{
            //    Console.WriteLine(gameBoard[i]);
            //}

            for (int i = 0; i < 9; i++)
            {
                // Print Board
                if (i % 2 == 0)
                {
                    Console.WriteLine("Player 1's Turn");
                }
                else
                {
                    Console.WriteLine("Player 2's Turn");
                }

            }
        }
        public byte Turn(byte[] gameBoard)
        {
            byte convertedTurn = 10;
            while (convertedTurn == 10)
            {
                Console.Write("Enter your next move: ");
                string playerTurn = Console.ReadLine();
                try
                {
                    convertedTurn = Convert.ToByte(playerTurn);
                    if (gameBoard[convertedTurn - 1] != 0)
                    {
                        Console.WriteLine("Oops! Someone already went there. Enter another number");
                        convertedTurn = 10;
                    }
                    else if (convertedTurn > 9 || convertedTurn < 1)
                    {
                        Console.WriteLine("Oops! That's not a square you can choose. Enter a number between 1 and 9");
                        convertedTurn = 10;
                    }
                    if (convertedTurn != 10)
                    {
                        return convertedTurn;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse '{playerTurn}', please enter a number between 1 and 9");
                }

            }

        }
    }
}
