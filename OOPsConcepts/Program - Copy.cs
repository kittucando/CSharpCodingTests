using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts
{
    class Program : A //, B - Abstract classes wont support Multiple inheritance
    {
        private Program():base() { }
        private Program(int v, string d) : base(0123123, text: "asfkjhas kfjasfj") { }
        static void Main(string[] args)
        {

          // A a = new A();//cant create an instance of an abstract class
           A a = new Program();//we can assign a class object to abstract class
            a.MyMethod();            
            a.MyMethod2();

            A b = new Program(34434123, "asfkjhas kfjasfj");//we can assign a class object to abstract class
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
