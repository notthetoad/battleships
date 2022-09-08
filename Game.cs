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
            return Board[x, y] == 0;
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

        public bool CanShipBePlaced(Ship ship)
        {
            if (!DoesShipFit(ship))
                return false;

            for (int i = 0; i < ship.size; i++)
            {
                if (!IsSquareEmpty(ship.x, ship.y+i))
                    return false;
            }
            return true;
        }

        public bool InsertShipHorizontal(Ship ship)
        {
            if (!CanShipBePlaced(ship))
                return false;

            for (int i = 0; i < ship.size; i++)
            {
                Board[ship.x, ship.y+i] = 1;
            }
            return true;
        }

        public bool InsertShipVertical(Ship ship)
        {
            if (!CanShipBePlaced(ship))
                return false;

            for (int i = 0; i < ship.size; i++)
            {
                Board[ship.x+i, ship.y] = 1;
            }
            return true;
        }

        // Metoda, która wstawia wszystkie statki po kolei. Dopóki wszystkie statki nie zostaną umieszcone (pętla), twórz statki i próbuj je umieścić, jeżeli dany statek nie może być umieszczony na planszy, wylosuj nowy i próbuj do skutku. 
        
        
    }
}
