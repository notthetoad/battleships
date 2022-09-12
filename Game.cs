namespace Battleships;

class Game
{
  public const int BoardSize = 10;
  public const int ShipCount = 3;
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
    ships = new Ship[] { new Battleship(), new Destroyer(), new Destroyer() };
  }

  private void PlaceShips()
  {
    Random rnd = new();
    foreach (Ship ship in ships)
    {
      bool isPlacingShip = true;
      while (isPlacingShip)
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

  private bool IsGameOver()
  {
    foreach (Ship ship in ships)
    {
      if (ship.Hitpoints > 0)
        return false;
    }
    return true;
  }

  public void Start()
  {
    Setup();
    MainLoop();
  }

  public void MainLoop()
  {
    while (!IsGameOver())
    {
      board.Print(true);
      char rawX;
      int rawY;
      int x = -1;
      int y = -1;

      bool isInputValid = false;
      do
      {
        System.Console.Write("Awaiting orders! >> ");
        try
        {
          InputUtils.ReadUserInput(out rawX, out rawY);
        }
        catch (System.FormatException e)
        {
          System.Console.WriteLine("Invalid format! Please use correct format e.g. 'a5'");
          continue;
        }

        if (!InputUtils.IsValidCharCoord(rawX))
        {
          System.Console.WriteLine("First coordinate should be a letter!");
          continue;
        }
        InputUtils.ParseRawCoord(rawX, rawY, out x, out y);
        if (x < 0 || y < 0 || x >= BoardSize || y >= BoardSize)
        {
          System.Console.WriteLine("No such field on the board!");
          continue;
        }
        if (board.WasCellShot(x, y))
        {
          System.Console.WriteLine("Field was already bombarded!");
          continue;
        }

        isInputValid = true;

      } while (!isInputValid);

      board.FireAt(x, y);
    }
  }
}
