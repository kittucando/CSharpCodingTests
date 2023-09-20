using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingTests.GeneralCodingTests
{
    internal class SwappingNumbers
    {
        internal void Without3rdNumber()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"Before swapping: a = {a}, b = {b}");

            // Swap using XOR operator
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine($"After swapping: a = {a}, b = {b}");
        }
    }
}
