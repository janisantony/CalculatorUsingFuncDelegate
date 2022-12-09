using System;

namespace CalcuUsingDelegateAsArgument
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> addDelegate = new Func<double, double, double>(AddMethod);
            Calculator(addDelegate);

            Func<double, double, double> subtractDelegate = new Func<double, double, double>(SubtractMethod);
            Calculator(SubtractMethod);

            Func<double, double, double> multiplyDelegate = new Func<double, double, double>(MultiplyMethod);
            Calculator(MultiplyMethod);

            Func<double, double, double> divideDelegate = new Func<double, double, double>(DivideMethod);
            Calculator(DivideMethod);

        }

        private static void Calculator(Func<double,double,double> calcFunction)
        {
            Console.WriteLine(calcFunction(20,40));
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
