using System;

namespace DelegateWithIntReturnType
{
    class Program
    {
        public delegate int AddDelegate(int firstNumber, int secNumber);
        static void Main(string[] args)
        {
            var addDelegate = new AddDelegate(AddNumbers);
            AddFunction(addDelegate);            
        }
        static void AddFunction(AddDelegate addDelegate)
        {
         Console.WriteLine(addDelegate(30, 20));
        }
        static int AddNumbers(int firstNumber,int secNumber)
        {
            return firstNumber + secNumber;

        }
    }
}
