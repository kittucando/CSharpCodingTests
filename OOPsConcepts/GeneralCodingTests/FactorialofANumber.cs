using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestions.GeneralCodingTests
{
    internal class FactorialOfANumber
    {
        
        internal void GetFactorialOfANumber()
        {
            Console.Write("Enter a non-negative integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            long factorial = CalculateFactorial(number);

            Console.WriteLine("The factorial of " + number + " is " + factorial);
        }

        internal long CalculateFactorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Factorial is defined only for non-negative integers.");

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }

}

