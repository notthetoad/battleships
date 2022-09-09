namespace Battleships
{
    class Field
    {
        private bool isEmpty = true;

        public bool IsEmpty
        {
            get => isEmpty;
            set => isEmpty = !isEmpty;
        }
    }
}
