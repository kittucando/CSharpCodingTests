using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestions.GeneralCodingTests
{
    internal class FindDuplicatesInAnArray
    {
        //Using HashTable
        internal void FindDuplicatesInGivenArrayByHashTable()
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



        //using Dictionary
       
        internal void FindDuplicatesInGivenArrayByDictionary()
        {
            int[] arr = { 1, 2, 3, 4, 2, 7, 8, 8, 3, 10, 10 };

            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (!frequency.ContainsKey(num))
                {
                    frequency[num] = 0;
                }
                frequency[num]++;
            }

            Console.WriteLine("Duplicates:");
            foreach (var pair in frequency)
            {
                if (pair.Value > 1)
                {
                    Console.WriteLine(pair.Key);
                }
            }
        }
    }

}



