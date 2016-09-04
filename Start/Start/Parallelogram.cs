using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    class Parallelogram : Quadrilateral
    {
        public int extent { get; set; }

        public Parallelogram (double width, double height, int extent)
        {
            this.width = width;
            this.height = height;
            this.extent = extent;

        }

        public override double getArea()
        {
            return width * height;
        }

        public override void draw(char symbol, bool filled)
        {
            throw new NotImplementedException();
        }
    }
}
