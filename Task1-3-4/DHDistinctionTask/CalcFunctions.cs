using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHDistinctionTask
{
    public class CalcFunctions
    {

        /// <summary>
        /// Calculator Add Function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns> the sum of a and b</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }


        /// <summary>
        /// Calculator Substract Function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>the result of substracting b from a</returns>
        public int Substract(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Calculator Multiply Function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>the result of a multiply b</returns>
        public int Multiply(int a, int b)
        {
            return a * b;
        }


        /// <summary>
        /// Calculator Divide Function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>the result of a divide by b</returns>
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
