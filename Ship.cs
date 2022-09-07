namespace Battleships
{
    class Ship
    {
        public int size;
        public int[2] position;
        public int direction;
        public int[size] hit;
        public bool sunk;

        Ship(int size, int[2] position, int direction)
        {
            this.size = size;
            this.position = position;
            this.direction = direction;
        }
    }
}
