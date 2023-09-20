using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestions.GeneralCodingTests
{
    internal class GenerateRandomNumbers
    {
        private int seed;
        public GenerateRandomNumbers()
        {
            // Use current time as seed
            seed = (int)DateTime.Now.Ticks;
        }

        public int Next()
        {
            // Generate a pseudo-random number using a simple algorithm
            seed = (seed * 1103515245 + 12345) & 0x7FFFFFFF;
            return seed;
        }

        //internal void GenerateRandomValues()
        //{

        //    // Create a Random object
        //    Random random = new Random();

        //    // Generate a random integer
        //    int randomNumber = random.Next(); // Generates a non-negative random integer

        //    Console.WriteLine("Random Number: " + randomNumber);

        //    // Generate a random integer within a specific range (e.g., between 1 and 100)
        //    int randomInRange = random.Next(1, 101); // Generates a random integer between 1 and 100 (inclusive)

        //    Console.WriteLine("Random Number in Range (1-100): " + randomInRange);

        //    // Generate a random double between 0 and 1
        //    double randomDouble = random.NextDouble(); // Generates a random double between 0 and 1

        //    Console.WriteLine("Random Double: " + randomDouble);

        //    // Generate a random boolean
        //    bool randomBoolean = random.Next(2) == 0; // Generates either true or false randomly

        //    Console.WriteLine("Random Boolean: " + randomBoolean);
        //}
    }

}
