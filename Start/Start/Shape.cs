using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    public abstract class Shape
    {
        public abstract double getArea();
        //public abstract void draw(char symbol);
        public abstract void draw(char symbol, bool filled);
    }
}
