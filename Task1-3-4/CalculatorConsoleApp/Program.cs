using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DHDistinctionTask;
using AdvanceMaths;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcFunctions _func = new CalcFunctions();
            CalculatorFunctions2 _advancefunc = new CalculatorFunctions2();

            Console.WriteLine("Please enter your first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your first number:");
            int b = int.Parse(Console.ReadLine());

            int add = _func.Add(a, b);
            int substract = _func.Substract(a, b);
            int multiply = _func.Multiply(a, b);
            int divide = _func.Divide(a, b);
            Console.WriteLine("============================");
            Console.WriteLine("My DHD Task Demonstartion Example");
            Console.WriteLine("============================");

            Console.WriteLine("============================");
            Console.WriteLine("Add: {0}", add);
            Console.WriteLine("Substract: {0}", substract);
            Console.WriteLine("Multiply: {0}", multiply);
            Console.WriteLine("Divide: {0}", divide);
            Console.WriteLine("============================");

            double power = _advancefunc.Power(b, 2);
            double root = _advancefunc.SquareRoot(b);
            Console.WriteLine("============================");
            Console.WriteLine("Second Number^2: {0}", power);
            Console.WriteLine("First Number^-2: {0}", root);
            Console.WriteLine("============================");

            Console.ReadLine();
        }
    }
}
