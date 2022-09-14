namespace Battleships;

class Destroyer : Ship
{
  private static string ShipClass = "Destroyer";
  private static int ShipSize = 4;

  public Destroyer() : base(ShipSize, ShipClass) { }
}
