namespace Battleships;

public abstract class Ship
{
  private int length;
  private int hitpoints;
  private string shipClassName;

  public Ship(int length, string shipClassName)
  {
    this.length = length;
    this.hitpoints = length;
    this.shipClassName = shipClassName;
  }

  public int Length
  {
    get => length;
  }

  public int Hitpoints
  {
    get => hitpoints;
  }

  public void Hit()
  {
    if (hitpoints > 0)
      hitpoints -= 1;
  }

  public string ShipClassName
  {
    get => shipClassName;
  }
}
