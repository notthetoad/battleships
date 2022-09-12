namespace Battleships;

class Destroyer : Ship
{
  private static string ShipClassName = "Destroyer";
  private static int ShipSize = 4;

  public Destroyer() : base(ShipSize, ShipClassName) { }
}
