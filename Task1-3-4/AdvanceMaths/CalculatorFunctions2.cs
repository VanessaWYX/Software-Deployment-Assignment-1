using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceMaths
{
    public class CalculatorFunctions2
    {

        /// <summary>
        /// Calculator Power Function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns> a to power of b</returns>
        public double Power(int a, int b)
        {
            return Math.Pow(a,b);
        }

        /// <summary>
        /// Calculator Square Root Function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns> a to power of b</returns>
        public double SquareRoot(int a)
        {
            return Math.Sqrt(a);
        }
    }
}
