
using System;

namespace CSharpCodingTests
{
    internal class PalindromeNumber
    {       
        internal bool IsPalindrome(int number) // we call not access in main method without modifier since default is private
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

        internal void GetPalindromeNumber()
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
        }
    }
}
