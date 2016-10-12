using System;

namespace Start
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle (int width, int height) : this(width, height, 0, 0)
        {
        }

        public Rectangle(int width, int height, int x, int y)
        {
            Width = width;
            Height = height;
            X = x;
            Y = y;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override void Draw(char symbol)
        {
            Draw(symbol, false);
        }

        public void Draw(char symbol, bool filled)
        {
            for (var i = 0; i < Height + Y; i += 1)
            {
                if (i >= Y)
                {
                    for (var j = 0; j < Width + X; j += 1)
                    {
                        while (j < X)
                        {
                            Console.Write(" ");
                            j += 1;
                        }
                        if (filled || (i == Y) || (i == Height + Y - 1)
                            || (j == X) || (j == Width + X - 1))
                            Console.Write(symbol);
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }

        public void Draw()
        {
            Draw('+',false);
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
