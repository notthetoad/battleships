namespace Battleships
{
    class Ship
    {
        public int size = 5;
        //public int[2] position;
        public int direction = 0;
        //public int[size] hit;
        //public bool sunk;

        public Ship(int rand)
        {
            //this.position = position;
            this.direction = rand;
        }
    }
}
