using System;

namespace CheckNumbersEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterNumbersForComparison();
        }

        private static void EnterNumbersForComparison()
        {
            int firstNumber;
            int secNumber;
            bool numberCheck = false;
            while (!numberCheck)
            {
                Console.WriteLine("Enter the first number");
                if (int.TryParse(Console.ReadLine(), out firstNumber))
                {
                    while (true)
                    {
                        Console.WriteLine("Enter the second number");
                        if (int.TryParse(Console.ReadLine(), out secNumber))
                        {
                            CheckNumbersAreEqual(firstNumber, secNumber);
                            numberCheck = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                }
            }
        }

        private static void CheckNumbersAreEqual(int firstNumber, int secNumber)
        {
            if (firstNumber == secNumber)
            {
                Console.WriteLine("Both numbers are equal");
            }
            else
            {
                Console.WriteLine("Both numbers are not equal");
            }
        }
    }
}
