using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestions.GeneralCodingTests
{
    internal class Check2ArraysEqual
    {
        internal void Check2ArraysAreEqual()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 1, 2, 3, 4, 5 };

            bool areEqual = ArraysAreEqual(array1, array2);

            if (areEqual)
            {
                Console.WriteLine("The arrays are equal.");
            }
            else
            {
                Console.WriteLine("The arrays are not equal.");
            }
        }

        internal bool ArraysAreEqual<T>(T[] array1, T[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (!array1[i].Equals(array2[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }

}

