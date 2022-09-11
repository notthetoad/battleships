namespace Battleships;

public class Cell
{
  private Ship ship;
  private bool wasShot;

  public bool IsEmpty
  {
    get => ship == null;
  }

  public bool WasShot
  {
    get => wasShot;
  }

  public void AssignShip(Ship ship)
  {
    this.ship = ship;
  }

  public void FireAt()
  {
    this.wasShot = true;

    if (IsEmpty)
      System.Console.WriteLine("Miss!");
    else
    {
      this.ship.Hit();
      if (this.ship.Hitpoints == 0)
        System.Console.WriteLine("Ship was sunk!");
      else
        System.Console.WriteLine("Hit!");
    }
  }
}
