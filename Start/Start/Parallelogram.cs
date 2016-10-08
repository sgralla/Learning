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

        public Parallelogram (int width, int height, int extent)
        {
            this.Width = width;
            this.Height = height;
            this.extent = extent;

        }

        public override int GetArea()
        {
            return Width * Height;
        }

        public override void Draw(char symbol, bool filled)
        {
            throw new NotImplementedException();
        }
    }
}
