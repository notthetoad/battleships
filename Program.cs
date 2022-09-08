using System;
using Battleships;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        //Console.WriteLine("\n");
        //game.printBoard(); 
        Random rnd = new Random();
        int num = rnd.Next(2);
        int x = rnd.Next(10);
        int y = rnd.Next(10);
        Ship ship = new Ship(num, x, y);
        bool fit = game.DoesShipFit(ship);
        Console.WriteLine("Direction: {0}", ship.direction);
        Console.WriteLine("Does fit? {0}", fit);
        Console.WriteLine("X: {0}\tY: {1}", ship.x, ship.y);
        game.InsertShipHorizontal(ship); 
        game.InsertShipVertical(ship);
        game.printBoard();
    }
}
