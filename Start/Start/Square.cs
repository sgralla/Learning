using System;

namespace Start
{
    class Square : Quadrilateral
    {
        public double size { get; set; }

        public Square(double size)
        {
            this.size = size;
            //this.height = size;
        }

        public override double getArea()
        {
            return size * size;
        }

        public override void draw(char symbol, bool filled)
        {
            var Dsquare = new draw(size, size, symbol, filled);
            Dsquare.symboldraw();
        }
    }
}
