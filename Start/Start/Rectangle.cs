using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    internal class Rectangle : Quadrilateral
    {
        public Rectangle (int width, int height)
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
            var recDraw = new draw(height, width, symbol, filled);
            recDraw.symboldraw();
        }

        public void Rotate()
        {
            var temp = width;
            width = height;
            height = temp;
        }

        public void Hoch2()
        {
            width = width * width;
            height = height * height;
        }

        public void Inner()
        {
            width = width - 2;
            height = height - 2;
        }
    }
}
