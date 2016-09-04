using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    class Rectangle : Quadrilateral 
    {
        public Rectangle (double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double getArea()
        {
            return width * height;
        }

        public override void draw(char symbol, bool filled)
        {
            var RecDraw = new draw(height, width, symbol, filled);
            RecDraw.symboldraw();
        }
    }
}
