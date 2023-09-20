using System;
using System.Collections.Generic;



namespace CSharpCodingTests
{

    internal class FindDuplicateFromArray

    {
        private static void FindDuplicate()
        {
            int[] arr = { 1, 2, 3, 4, 2, 7, 8, 8, 3, 10, 10 };

            HashSet<int> uniqueElements = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            foreach (int num in arr)
            {
                if (!uniqueElements.Add(num))
                {
                    duplicates.Add(num);
                }
            }

            Console.WriteLine("Duplicates:");
            foreach (int duplicate in duplicates)
            {
                Console.WriteLine(duplicate);
            }
        }
    }

}




