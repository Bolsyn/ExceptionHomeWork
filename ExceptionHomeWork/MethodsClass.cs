using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHomeWork
{
    class MethodsClass
    {
        public double DivNumbers(double number, double anotherNumber)
        {
            if (number == 0 || anotherNumber == 0)
            {
                throw new ArgumentException("Argument equal zero");
            }
            else if (number == null || anotherNumber == null)
            {
                throw new ArgumentNullException("Argument are/is null ");
            }
            else
            {
                return number / anotherNumber;
            }
        }
    }
}
