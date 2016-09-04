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

        public override void draw(char symbol)
        {
            for (int i = 0; i < height; i+=1)
            {
                for (int j = 0; j < width; j+=1)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        public override void draw(char symbol, bool filled)
        {
            if (filled)
            {
                draw(symbol);
            }
            else
            {
                for (int i = 0; i < width; i += 1)
                {
                    for (int j = 0; j < height; j += 1)
                    {
                        if (i == 0 || i == width-1 || j == 0 || j == height-1)
                        {
                            Console.Write(symbol);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
