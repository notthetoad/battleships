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
            coords[0] = rnd.Next(10);
            coords[1] = rnd.Next(10);
            return coords;
        }

        public void InsertRandomSquare()
        {
            int[] pos = GetRandomCoordinates();
            Board[pos[0], pos[1]] = 1;
        }

        public bool DoesCollide(int x, int y)
        {
            if (Board[x, y] == 1)
                return true;
            return false;
        }

        // add direction to ship class to see if it's horizontal or vertical
        public bool DoesShipFit(int x, int y, Destroyer ship)
        {
            if (ship.Direction == 0)
            {
                if (Board[x, y+ship.Size] < Board.GetLength(ship.Direction)
                    return true;
                else
                    return false;
            }
            else
            {
                if (Board[x+ship.Size, y] < Board.GetLength(ship.Direction)
                    return true;
                else
                    return false;
            }
        }

        public void InsertShipHorizontal()
        {
            Destroyer destroyer = new Destroyer();
            int[] pos = GetRandomCoordinates();
            for (int i = 0; i < destroyer.GetSize(); i++)
            {
                Console.WriteLine("rnd1: {0}\trnd2: {1}\ti: {2}", pos[0], pos[1], i);
                if (pos[1]+destroyer.GetSize() < Board.GetLength(1))
                    Board[pos[0], pos[1]+i] = 1;
                else
                    Board[pos[0], pos[1]-i] = 1;
            }
        }

        // Same exception as in InsertShipHorizontal(). Will need to add checking for other ship because they cannot cross. Need to add inserting at the back if there is not enough space.
        public void InsertShipVertical()
        {
            Battleship battleship = new Battleship();
            int[] pos = GetRandomCoordinates();
            for (int i = 0; i < battleship.GetSize(); i++)
            {
                Console.WriteLine("rnd1: {0}\trnd2: {1}\ti: {2}", pos[0], pos[1], i);
                if (pos[0]+battleship.GetSize() < Board.GetLength(0))
                    Board[pos[0]+i, pos[1]] = 1;
                else
                    Board[pos[0]-i, pos[1]] = 1;
            }
        }

        // Make the board of enums that has data like empty, ship, wasBombed
        // Want to make it so random ship will get random number 0-1 to decide if it is placed vertically or horizontally
        //public void PopulateBoard(object[] ships)
        //{
        //    Random rnd = new Random();
        //    int num = rnd.Next(2);
        //    int ship;
        //    for (int i = 0; i < ships.GetLength(); i++)
        //    {
        //        ship = rnd.Next(3); 
        //    
        //        switch(num)
        //        {
        //            case 1:
        //                InsertShipVertical(ships[ship]);
        //                break;
        //            case 2:
        //                InsertShipHorizontal(ships[ship]);
        //                break;
        //            default:
        //                return;
        //        }
        //    }
        //}
    }
}
