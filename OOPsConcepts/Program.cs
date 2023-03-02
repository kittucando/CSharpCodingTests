using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts
{
    class Program : A //, B - Abstract classes wont spport Mltpleinhertitance
    {
        static void Main(string[] args)
        {

            
        }

        public override void MyMethod()
        {
            Console.WriteLine();
        }
    }
    abstract class A
    {
        public abstract void MyMethod();
    }

    abstract class B
    {
        public abstract void MyMethod();
    }

    
}
