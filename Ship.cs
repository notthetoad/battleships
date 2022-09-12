namespace Battleships;

public abstract class Ship
{
  private int length;
  private int hitpoints;

  public Ship(int length)
  {
    this.length = length;
    this.hitpoints = length;
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

  public abstract string GetHitMessage();
}
