using System;
using Battleships;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        Console.WriteLine("\n");
        game.InsertShipHorizontal();
        game.InsertShipHorizontal();
        game.InsertShipVertical();
        game.printBoard(); 
    }
}
