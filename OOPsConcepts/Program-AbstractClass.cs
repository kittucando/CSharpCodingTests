using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts
{
    class Program : A //, B - Abstract classes wont support Multiple inheritance
    {
        static void Main(string[] args)
        {

          // A a = new A();//cant create an instance of an abstract class
           A a = new Program();//cant create an instance of an abstract class

            a.MyMethod();
            Console.Read();
        }

        public override void MyMethod()
        {
            Console.WriteLine("OverRidden abstract method :MyMethod ");
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
