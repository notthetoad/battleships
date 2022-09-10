namespace Battleships;

class Game
{
    public const int BoardSize = 10;
    public const int ShipCount = 3;
    public int[] ShipLengths = new int[] {5, 4, 4};
    private Board board;
    private Ship[] ships;

    public Game()
    {
        this.board = new Board(BoardSize);
        this.ships = new Ship[ShipCount];
    }

    public void Setup()
    {
        CreateShips();
        PlaceShips();
    }

    private void CreateShips()
    {
        for (int i = 0; i < this.ships.Length; i++)
        {
            ships[i] = new Ship(ShipLengths[i]); 
        }
    }

    private void PlaceShips()
    {
        Random rnd = new();
        foreach(Ship ship in ships)
        {
            bool isPlacingShip = true;
            while(isPlacingShip)
            {
                bool isVertical = rnd.Next(2) == 0;
                int maxX;
                int maxY;
                if (isVertical)
                {
                    maxX = BoardSize - 1;
                    maxY = BoardSize - ship.Length;
                }
                else
                {
                    maxX = BoardSize - ship.Length;
                    maxY = BoardSize - 1;
                }
                int x = rnd.Next(maxX + 1);
                int y = rnd.Next(maxY + 1);
                if (board.TryToPlaceShip(x, y, ship, isVertical))
                    isPlacingShip = false;
            }
        }
    }


}
