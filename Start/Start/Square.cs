using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override void draw(char symbol)
        {
            for (int i = 0; i < size; i += 1)
            {
                for (int j = 0; j < size; j += 1)
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
                for (int i = 0; i <= size; i+=1)
                {
                    for (int j = 0; j <= size; j+=1)
                    {
                        if (i == 0 || i == size) 
                            //|| j == 0 || j == (size-1))
                        {
                            Console.Write(symbol);
                        }
                        else if (j == 0 || j == size)
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
