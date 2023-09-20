using CSharpCodingTests.GeneralCodingTests;
using CSharpInterviewQuestions.GeneralCodingTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingTests
{
    class Program
    {
        public static void Main()
        {
            #region 1. Palindrome Number

            PalindromeNumber palindromeNumber = new PalindromeNumber();
            palindromeNumber.GetPalindromeNumber();

            #endregion

            #region 2. Palindrome string

            PalindromeString palindromeString = new PalindromeString();
            palindromeString.GetPalindromeString();        

            #endregion

            #region 3. Fibonacci series

            Fibonacci fibonacci = new Fibonacci();
            fibonacci.WriteFibonacci();

            #endregion

            #region 4. Find Duplicate elements in an Array           

            FindDuplicatesInAnArray findDuplicatesInAnArray = new FindDuplicatesInAnArray();

            //by using Hash table
            findDuplicatesInAnArray.FindDuplicatesInGivenArrayByHashTable();

            //by using Dictionary
            findDuplicatesInAnArray.FindDuplicatesInGivenArrayByDictionary();

            #endregion

            #region 5. Check Whether A Number is Armstrong Number or Not

            FindArmstrongNumber findArmstrongNumber = new FindArmstrongNumber();
            findArmstrongNumber.Find();

            #endregion

            #region 6) Swap 2 Numbers without using a 3rd variable

            SwappingNumbers swappingNumbers = new SwappingNumbers();
            swappingNumbers.Without3rdNumber();

            #endregion

            #region 7. Check Whether A Number is Prime or Not

            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.CheckGivenNumberIsPrimeOrNot();


            #endregion

            #region 8. Generate Random Numbers

            GenerateRandomNumbers customRandom = new GenerateRandomNumbers();
            // Generate random numbers
            for (int i = 0; i < 5; i++)
            {
                int randomNumber = customRandom.Next();
                Console.WriteLine("Random Number: " + randomNumber);
            }

            #endregion

            #region 9. Check Whether 2 Arrays Are 

            Check2ArraysEqual check2ArraysEqual = new Check2ArraysEqual();
            check2ArraysEqual.Check2ArraysAreEqual();

            #endregion

            #region 10. Find The Factorial of A Number

            FactorialOfANumber factorialOfANumber = new FactorialOfANumber();
            factorialOfANumber.GetFactorialOfANumber();

            #endregion

            Console.Read();

        }



    }





}
