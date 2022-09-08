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

        // Exception index range out of bounds when checking in inserting ship because x+i, y+i
        // need to also check if in array
        public bool IsSquareEmpty(int x, int y)
        {
            if (Board[x, y] == 1)
                return false;
            return true;
        }

        public bool DoesShipFit(Ship ship)
        {
            if (ship.direction == 0)
            {
                return (ship.x + ship.size < Board.GetLength(ship.direction));
            }
            else
            {
                return (ship.y + ship.size < Board.GetLength(ship.direction));
            }
        }

        public void InsertShipVertical(Ship ship)
        {
            if (DoesShipFit(ship))
            {
                for (int i = 0; i < ship.size; i++)
                {
                    if (IsSquareEmpty(ship.x+i, ship.y))
                        Board[ship.x+i, ship.y] = 1;
                }
            }
        }

        public void InsertShipHorizontal(Ship ship)
        {
            if (DoesShipFit(ship))
            {
                for (int i = 0; i < ship.size; i++)
                {
                    if (IsSquareEmpty(ship.x, ship.y+i))
                        Board[ship.x, ship.y+i] = 1;
                }
            }
        }

        public void InsertShip(Ship ship)
        {
            if (DoesShipFit(ship))
            {
                for (int i = 0; i < ship.size; i++)
                {
                    if (ship.direction == 0)
                    {
                        if (IsSquareEmpty(ship.x+i, ship.y))
                        {
                            Board[ship.x+i, ship.y] = 1;
                        }
                    }

                }
            }
        }
    }
}
