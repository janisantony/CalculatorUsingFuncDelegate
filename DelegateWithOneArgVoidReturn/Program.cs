using System;

namespace DelegateWithOneArgVoidReturn
{
    class Program
    {
        public delegate void OddOrEvenDelegate(int number);
        static void Main(string[] args)
        {
            var oddOrEvenDelegate = new OddOrEvenDelegate(CheckOddOrEven);
            oddOrEvenDelegate.Invoke(30);
        }

        static void CheckOddOrEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
