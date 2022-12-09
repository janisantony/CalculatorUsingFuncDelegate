using System;

namespace CalculatorActionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<double, double> addDelegate = new Action<double, double>(AddMethod);
            Calculator(addDelegate);

            Action<double, double> subtractDelegate = new Action<double, double>(SubtractMethod);
            Calculator(SubtractMethod);

            Action<double, double> multiplyDelegate = new Action<double, double>(MultiplyMethod);
            Calculator(MultiplyMethod);

            Action<double, double> divideDelegate = new Action<double, double>(DivideMethod);
            Calculator(DivideMethod);

            Calculator(addDelegate += subtractDelegate += multiplyDelegate += divideDelegate);

        }

        private static void Calculator(Action<double, double> calcFunction)
        {
            calcFunction(20, 40);
        }
        private static void AddMethod(double firstNumber, double secNumber)
        {
            Console.WriteLine(firstNumber + secNumber);
        }

        private static void SubtractMethod(double firstNumber, double secNumber)
        {
            Console.WriteLine(firstNumber - secNumber);

        }

        private static void MultiplyMethod(double firstNumber, double secNumber)
        {
            Console.WriteLine(firstNumber * secNumber);

        }
        private static void DivideMethod(double firstNumber, double secNumber)
        {
            Console.WriteLine(firstNumber / secNumber);

        }
    }
}
