using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    public abstract class Shape
    {
        public abstract int GetArea();
        //public abstract void draw(char symbol);
        public abstract void Draw(char symbol, bool filled);
    }
}
