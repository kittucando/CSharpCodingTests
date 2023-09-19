using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts
{
    using System;

    class Program
    {
        static bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }

            return originalNumber == reversedNumber;
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int input;

            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (IsPalindrome(input))
                {
                    Console.WriteLine($"{input} is a palindrome.");
                }
                else
                {
                    Console.WriteLine($"{input} is not a palindrome.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            Console.Read();
        }
    }






}
