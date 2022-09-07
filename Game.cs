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

        public int[] GetRandomCoordinates()
        {
            Random rnd = new Random();
            int[] coords = new int[2];
            coords[0] = rnd.Next(11);
            coords[1] = rnd.Next(11);
            return coords;
        }

        public void InsertRandomSquare()
        {
            int[] pos = GetRandomCoordinates();
            Board[pos[0], pos[1]] = 1;
        }

        // 1. Get random position
        // 2. Check to see if ship of size 5 fits
        // 3. if position - size of ship is greater or equal to 0 ship can be inserted
        // if it is not greater or equal to 0 we can:
        //  - search for new random number that checks these conditions
        //  - start inserting squares at the back of the ship
        //  I think this logic is going in the right direction, just need to work out how to make logical statement that will meet conditions I have
        //  This works, but is weird exception if 1st dimension idx is 10 and 2nd dimension idx is 0: IndexOutOfRangeException
        public void InsertShipHorizontal()
        {
            int[] pos = GetRandomCoordinates();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("rnd1: {0}\trnd2: {1}\ti: {2}", pos[0], pos[1], i);
                if (pos[1]+5 <= 10)
                {
                    Board[pos[0], pos[1]+i] = 1; 
                }
            }
        }

        public void InsertShipHorizontal2()
        {
            int[] pos = GetRandomCoordinates();
            int i = 0;
            while (pos[1]+5 <= 10 && i < 5)
            {
                Board[pos[0], pos[1]+i] = 1;
                i++;
            }
        }

        public void InsertShipVertical()
        {
            
        }

        public void PopulateBoard()
        {
            
        }
    }
}
