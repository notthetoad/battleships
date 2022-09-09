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
    }
}
