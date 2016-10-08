using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle (int width, int height)
        {
            Width = width;
            Height = height;
            X = 0;
            Y = 0;
        }

        public Rectangle(int width, int height, int x, int y)
        {
            Width = width;
            Height = height;
            X = x;
            Y = y;
        }

        public override int GetArea()
        {
            return Width * Height;
        }

        public override void Draw(char symbol, bool filled)
        {
            for (var i = 0; i < Height + Y; i += 1)
            {
                if (X != 0)
                {
                    Console.Write(MoveString());
                }

                for (var j = 0; j < Width; j += 1)
                    if (i >= Y)
                    {
                        if (filled || (i == Y) || (i == Height + Y -1)
                            || (j == 0) || (j == Width - 1))
                            Console.Write(symbol);
                        else
                            Console.Write(" ");
                    }
                Console.WriteLine();
            }

        }

        public void Draw()
        {
            Draw('+',false);
        }

        private string MoveString()
        {
            var mString = "";
            for (var m = 0; m < X; m += 1)
            {
                mString += " ";
            }
            return mString;
        }


        public void Rotate()
        {
            var temp = Width;
            Width = Height;
            Height = temp;
        }

        public void Square()
        {
            Width = Width * Width;
            Height = Height * Height;
        }

        public void Root()
        {
            Width = (int)Math.Sqrt(Width);
            Height = (int)Math.Sqrt(Height);
        }

        public void Inner()
        {
            Width = Width - 2;
            Height = Height - 2;
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public void ResetPosition()
        {
            X = 0;
            Y = 0;
        }
    }
}
