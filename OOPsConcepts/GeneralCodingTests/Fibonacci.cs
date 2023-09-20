using System;

namespace CSharpCodingTests
{
    class Fibonacci
    {
        public void WriteFibonacci()
        {
            // Write Fibonacci series code
            //0 1 1 2 3 5 8 13 21,....
            int range = 0;
            range = Convert.ToInt32(Console.ReadLine());
            int i = 0, j = 1, k = 0;
            Console.Write(i + "  " + j + "  ");
            for (int l = 0; l <= range; l++)
            {
                k = i + j;
                i = j;
                j = k;
                Console.Write(k + "  ");
            }
            Console.Read();
        }
    }


   
    
    
}
