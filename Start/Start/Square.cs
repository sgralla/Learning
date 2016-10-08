using System;

namespace Start
{
    internal class Square : Rectangle
    {
        public int Size { get; set; }

        public Square(int size) : base(size, size)
        {
        }

        public Square(int size, int x, int y) : base(size, size, x, y)
        {
        }
    }
}
