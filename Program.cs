using System;
using Battleships;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.printBoard(); 
        Console.WriteLine("\n");
        //game.Board[2, 6] = 1;
        game.InsertRandomShip();
        game.printBoard(); 
    }
}
