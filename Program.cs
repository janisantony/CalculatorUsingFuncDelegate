using System;

namespace CalculatorUsingFuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> addDelegate = new Func<double, double, double>(AddMethod);
            Console.WriteLine("Add :" +addDelegate(20, 30));

            Func<double, double, double> subtractDelegate = new Func<double, double, double>(SubtractMethod);
            Console.WriteLine("Subtract :" + subtractDelegate(20, 30));

            Func<double, double, double> multiplyDelegate = new Func<double, double, double>(MultiplyMethod);
            Console.WriteLine("Multiplly :" + multiplyDelegate(20, 30));

            Func<double, double, double> divideDelegate = new Func<double, double, double>(DivideMethod);
            Console.WriteLine("Divide :" + divideDelegate(20, 30));

        }


        private static double AddMethod(double firstNumber, double secNumber)
        {
            return firstNumber + secNumber;
        }

        private static double SubtractMethod(double firstNumber, double secNumber)
        {
            return firstNumber - secNumber;
        }

        private static double MultiplyMethod(double firstNumber, double secNumber)
        {
            return firstNumber * secNumber;
        }

        private static double DivideMethod(double firstNumber, double secNumber)
        {
            return firstNumber / secNumber;
        }
    }
}
