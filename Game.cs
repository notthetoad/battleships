using System;

namespace Battleships
{
    class Game
    {
        public int[,] Board {get; set;} = new int[10, 10];

        // First make a function that will random a number between 0-10
        // Second get random number to place value in first dimension array and then in second dimension array
        // Third make it 5 squares to put it in array, need to check if it will fit given the random number (place in array)
        // Fourth make it vertical instead of horizontal, need to check both dimensions if it will fit

        public void printBoard()
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Console.Write("{0} ", Board[i,j]);
                }
                Console.Write("\n");
            }
        }

        public int getRandomNumber()
        {
            Random rnd = new Random();
            int num = rnd.Next(11);
            return num;
        }

        public void InsertRandomShip()
        {
            int num = getRandomNumber();
            Board[num, num] = 1;
        }
    }
}
