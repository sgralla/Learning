using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle(5, 4);
            rect.draw('#',false);

            Console.WriteLine();

            rect.draw('#',true);

            Console.WriteLine();

            rect.draw('#',false);

            Console.WriteLine();


            var sq = new Square(7);

            sq.draw('o', false);
        

            Console.ReadKey();
        }
    }
}
