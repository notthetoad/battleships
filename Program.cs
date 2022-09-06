using System;
using Battleships;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Battleships.Game();
        for (int i = 0; i < game.board.GetLength(0); i++)
        {
            for (int j = 0; j < game.board.GetLength(1); j++)
            {
                Console.Write("{0} ", 0);
            }
            Console.Write("{0}\n", 0);
        }
    }
}
