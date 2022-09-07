using System;
using Battleships;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.printBoard(); 
        Console.WriteLine("\n");
        //game.InsertRandomSquare();
        //game.InsertShipHorizontal();
        //game.InsertShipHorizontal2();
        game.InsertShipVertical();
        game.printBoard(); 
    }
}
