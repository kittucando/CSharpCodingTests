using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingTests
{
    internal class ConcreteClass1 : A //, B - Abstract classes won't support Multiple inheritance
    {
        private ConcreteClass1():base() { }
        private ConcreteClass1(int v, string d) : base(0123123, text: "asfkjhas kfjasfj") { }
        static void CheckAbstractMethods(string[] args)
        {

          // A a = new A();//cant create an instance of an abstract class
           A a = new ConcreteClass1();//we can assign a class object to abstract class
            a.MyMethod();            
            a.MyMethod2();

            A b = new ConcreteClass1(34434123, "asfkjhas kfjasfj");//we can assign a class object to abstract class
            b.MyMethod();
            b.MyMethod2();
            Console.Read();
        }

        public override void MyMethod()
        {
            Console.WriteLine("OverRidden abstract method :MyMethod ");
        }
    }
   public abstract class A
    {
        int testno = 10;

        string ClassName=string.Empty;

        public A()
        {
            testno = 11;
        }
        public A(int i, string text)
        {
            
            testno = i;
            ClassName = text;
        }
        public abstract void MyMethod();

        public  void MyMethod2()
        {
            Console.WriteLine("abstract implemented method :MyMethod2--{0}, {1} ", testno, ClassName);

        }
    }

    abstract class B
    {
        public abstract void MyMethod();
    }

    
}
