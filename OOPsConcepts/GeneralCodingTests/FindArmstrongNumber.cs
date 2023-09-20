using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestions.GeneralCodingTests
{
    internal class FindArmstrongNumber
    {
        internal void Find()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsArmstrong(number))
            {
                Console.WriteLine("{0} is an Armstrong number.", number);
            }
            else
            {
                Console.WriteLine("{0} is not an Armstrong number.", number);
            }
        }

        internal bool IsArmstrong(int num)
        {
            int numberOfDigits = num.ToString().Length;
            int sum = 0;
            int temp = num;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, numberOfDigits);
                temp /= 10;
            }

            return sum == num;
        }
    }

}
