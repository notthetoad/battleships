using System;

namespace Battleships
{
    class Game
    {
        public int[,] Board {get; set;} = new int[10, 10];

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

        public bool IsSquareEmpty(int x, int y)
        {
            if (Board[x, y] == 1)
                return false;
            return true;
        }

        public bool DoesShipFit(int x, int y, Ship ship)
        {
            if (ship.direction == 1)
            {
                return (y+ship.size < Board.GetLength(ship.direction));
            }
            else
            {
                return (x + ship.size < Board.GetLength(ship.direction));
            }
        }
    }
}
