using System;

namespace DelegateWithNoArguments
{
    public delegate void PrintDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            var printDelegate = new PrintDelegate(Print);
            printDelegate();
            printDelegate.Invoke();
        }

       static void Print()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
