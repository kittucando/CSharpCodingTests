using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpInterviewQuestions
{

    internal class FindDuplicateFromArray

    {
        static void Main()
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



}
