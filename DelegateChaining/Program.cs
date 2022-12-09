using System;

namespace DelegateChaining
{
    class Program
    {
        public delegate void CalculatorDelegate(double firstNumber, double secNumber);
        static void Main(string[] args)
        {
            var addDelegate = new CalculatorDelegate(AddMethod);
            addDelegate += SubtractMethod;
            addDelegate += MultiplyMethod;
            addDelegate += DivideMethod;
            addDelegate(30, 40);
             
          
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
