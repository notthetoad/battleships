using System;

namespace Battleships
{
    class Game
    {
        public int[,] Board {get; set;} = new int[10, 10];
        //public Field[,] Board {get; set;} = new Field[10, 10];

        public Field[,] MakeBoard()
        {
            Field[,] board = new Field[10,10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board[i, j] = new Field();
                    Console.Write("{0} ", board[i, j].IsEmpty);
                }
                Console.Write("\n");
            }
            return board;
        }

        public void PrintBoard()
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
    }
}
 //       public void printBoard()
 //       {
 //           for (int i = 0; i < Board.GetLength(0); i++)
 //           {
 //               for (int j = 0; j < Board.GetLength(1); j++)
 //               {
 //                   Console.Write("{0} ", Board[i,j]);
 //               }
 //               Console.Write("\n");
 //           }
 //       }

 //       public bool IsSquareEmpty(int x, int y)
 //       {
 //           return Board[x, y] == 0 && x < Board.GetLength(0) && y < Board.GetLength(1);
 //       }

 //       public bool DoesShipFit(Ship ship)
 //       {
 //           if (ship.direction == 0)
 //           {
 //               return (ship.x + ship.size < Board.GetLength(ship.direction));
 //           }
 //           else
 //           {
 //               return (ship.y + ship.size < Board.GetLength(ship.direction));
 //           }
 //       }

 //       public bool CanShipBePlaced(Ship ship)
 //       {
 //           if (!DoesShipFit(ship))
 //               return false;

 //           if (ship.direction == 0)
 //           {
 //               for (int i = 0; i < ship.size; i++)
 //               {
 //                   if (!IsSquareEmpty(ship.x+i, ship.y))
 //                       return false;
 //               }
 //               return true;
 //           }
 //           else
 //           {
 //               for (int i = 0; i < ship.size; i++)
 //               {
 //                   if (!IsSquareEmpty(ship.x, ship.y+i))
 //                       return false;
 //               }
 //               return true;
 //           }
 //       }

 //       public bool PlaceShip(Ship ship)
 //       {
 //           return (ship.direction == 0) ? InsertShipVertical(ship) : InsertShipHorizontal(ship);
 //       }

 //       public bool InsertShipHorizontal(Ship ship)
 //       {
 //           if (!CanShipBePlaced(ship))
 //               return false;

 //           for (int i = 0; i < ship.size; i++)
 //           {
 //               Board[ship.x, ship.y+i] = 1;
 //           }
 //           return true;
 //       }

 //       public bool InsertShipVertical(Ship ship)
 //       {
 //           if (!CanShipBePlaced(ship))
 //               return false;

 //           for (int i = 0; i < ship.size; i++)
 //           {
 //               Board[ship.x+i, ship.y] = 1;
 //           } 
 //           return true;
 //       }

 //      public void PlaceAllShips() 
 //      {
 //           for (int i = 0; i < 3; i++)
 //           {
 //               Ship ship = new Ship();
 //               while (!PlaceShip(new Ship())){};
 //           }
 //      }
 //   }
//}
