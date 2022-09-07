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
        Ship ship = new Ship(num);
        bool fit = game.DoesShipFit(8, 8, ship);
        Console.WriteLine(ship.direction);
        Console.WriteLine(fit);
    }
}
