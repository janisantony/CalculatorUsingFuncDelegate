using System;

namespace LamdaUsingFun
{
    class LamdaUsingFun
    {
        static void Main(string[] args)
        {

            Func<double, double,double> addNumFunc = ( firstNumber,  secondNumber) =>

                 firstNumber + secondNumber;


            Func<double, double, double> subtractNumFunc = ( firstNumber,  secondNumber) =>

                 firstNumber - secondNumber;

            Func<double, double, double> multiplyNumFunc = ( firstNumber,  secondNumber) =>

                 firstNumber * secondNumber;


            Func<double, double, double> divideNumFunc = ( firstNumber,  secondNumber) =>

                 firstNumber / secondNumber;


            Calculator(addNumFunc, 10, 3);

            Calculator(subtractNumFunc, 10, 3);

            Calculator(multiplyNumFunc, 10, 3);

            Calculator(divideNumFunc, 10, 3);

        }
        static void Calculator(Func<double, double,double> cal,double  firstNumber, double secondNumber)
        {
            Console.WriteLine(cal(firstNumber, secondNumber));
        }
    }
}