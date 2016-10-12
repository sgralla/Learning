using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Start
{
    internal class Square : Rectangle
    {
        public Square(int size) : base(size, size)
        {
        }

        public Square(int size, int x, int y) : base(size, size, x, y)
        {
        }

        /// <summary>
        /// Converts Square to Rhombus and nullifies the Square
        /// </summary>
        /// <param name="sq"></param>
        /// <param name="rho"></param>
        public static void ToRhombus(Square sq, out Rhombus rho)
        {
            ToRhombus(sq, out rho, false);
        }

        /// <summary>
        /// Converts Square to Rhombus and nullifies the Square if keep is false
        /// </summary>
        /// <param name="sq"></param>
        /// <param name="rho"></param>
        /// <param name="keep"></param>
        public static void ToRhombus(Square sq, out Rhombus rho, bool keep)
        {
            rho = new Rhombus(sq.Height * 2 - 1);
            if (!keep) sq = null;
        }

    }

}
