using System;

namespace DelegateWithArguments
{
    // Delegate pointing to a method having more than one argument and void as return type
    public delegate void NameDelegate(string firstName,string secName);
    class Program
    {
        static void Main(string[] args)
        {
            var nameDelegate = new NameDelegate(PrintName);
            nameDelegate("Virat","Kohli");
            nameDelegate.Invoke("Sachin","Tendulkar");
        }

        static void PrintName(string firstName,string secName)
        {
            Console.WriteLine(firstName+" "+secName);
        }
    }
}
