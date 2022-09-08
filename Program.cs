using System;
using Battleships;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        //Console.WriteLine("\n");
        //game.printBoard(); 
        Ship ship = new Ship();
        bool fit = game.DoesShipFit(ship);
        Console.WriteLine("Direction: {0}", ship.direction);
        Console.WriteLine("Does fit? {0}", fit);
        Console.WriteLine("X: {0}\tY: {1}", ship.x, ship.y);
        game.PlaceAllShips();
        game.printBoard();
    }
}
