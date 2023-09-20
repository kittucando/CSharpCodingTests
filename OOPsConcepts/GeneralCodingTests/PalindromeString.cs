using System;


namespace CSharpCodingTests
{
    internal class PalindromeString
    {
        internal bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
        internal  void GetPalindromeString()
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            if (!string.IsNullOrEmpty(inputString))
            {
                if (IsPalindrome(inputString))
                {
                    Console.WriteLine($"{inputString} is a palindrome.");
                }
                else
                {
                    Console.WriteLine($"{inputString} is not a palindrome.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

    }







}
