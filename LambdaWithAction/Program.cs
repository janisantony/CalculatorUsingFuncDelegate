using System;

namespace LamdaUsingAction
{
    class LamdaUsingAction
    {
        static void Main(string[] args)
        {

            Action<double, double> addNumFunc = (firstNumber, secondNumber) =>

                 Console.WriteLine(firstNumber + secondNumber);


            Action<double, double> subtractNumFunc = (firstNumber, secondNumber) =>

                     Console.WriteLine(firstNumber - secondNumber);

            Action<double, double> multiplyNumFunc = (firstNumber, secondNumber) =>

                    Console.WriteLine(firstNumber * secondNumber);


            Action<double, double> divideNumFunc = (firstNumber, secondNumber) =>

            Console.WriteLine(firstNumber / secondNumber);


            Calculator(addNumFunc, 10, 3);

            Calculator(subtractNumFunc, 10, 3);

            Calculator(multiplyNumFunc, 10, 3);

            Calculator(divideNumFunc, 10, 3);

        }
        static void Calculator(Action<double, double> cal, double firstNumber, double secondNumber)
        {
            cal(firstNumber, secondNumber));
        }
    }
}