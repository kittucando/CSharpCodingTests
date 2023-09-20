using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingTests
{
    // internal class ConcreteClass : Abstract1,Abstract2 -> Error: Abstract classes won't support Multiple inheritance
    internal class ConcreteClass : Abstract1
    {
        internal void CheckAbstractMethods(string[] args)
        {
            // Abstract1 abstract1ref = new Abstract1(); // Error: can't create an instance of an abstract class
            Abstract1 abstract1ref = new ConcreteClass(); //can create & assign a concrete class instance to an abstract class reference
            abstract1ref.MyMethod(); // goes to Abstract1 MyMethod not the ConcreteClass MyMethod

            ConcreteClass concreteClass = new ConcreteClass();
            concreteClass.MyMethod();
            Console.Read();
        }

        public override void MyMethod()
        {
            Console.WriteLine("OverRidden abstract method :MyMethod ");
        }
    }
    abstract class Abstract1
    {
        public abstract void MyMethod();
    }

    abstract class Abstract2
    {
        public abstract void MyMethod();
    }


}
