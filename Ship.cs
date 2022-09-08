namespace Battleships
{
    class Ship
    {
        public int size = 5;
        public int direction;
        public int x;
        public int y;
        //public int[size] hit;
        //public bool sunk;

        public Ship(int rand, int x, int y)
        {
            this.direction = rand;
            this.x = x;
            this.y = y;
        }
    }
}
