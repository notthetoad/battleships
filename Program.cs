using System;
using Battleships;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        Ship ship = new Ship();
        Console.WriteLine("X: {0}\tY: {1}", ship.x, ship.y);
        game.PlaceAllShips();
        game.printBoard();
    }
}
