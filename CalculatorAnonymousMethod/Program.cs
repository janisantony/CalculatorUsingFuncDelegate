using System;

namespace CalculatorAnonymousMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double,double,double> anonymousAdd = delegate (double firstNumber, double secondNumber)
            {
                return firstNumber + secondNumber;
            };

            Func<double, double, double> anonymousSubtract = delegate (double firstNumber, double secondNumber)
            {
                return firstNumber - secondNumber;
            };

            Func<double, double, double> anonymousMultiply = delegate (double firstNumber, double secondNumber)
            {
                return firstNumber * secondNumber;
            };

            Func<double, double, double> anonymousDivide = delegate (double firstNumber, double secondNumber)
            {
                return firstNumber / secondNumber;
            };

            Calculator(anonymousAdd);
            Calculator(anonymousSubtract);
            Calculator(anonymousMultiply);
            Calculator(anonymousDivide);
        }
        private static void Calculator(Func<double, double, double> calcFunction)
        {

            Console.WriteLine(calcFunction(20, 40));
        }
    }
}
