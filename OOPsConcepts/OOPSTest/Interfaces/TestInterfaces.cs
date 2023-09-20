using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingTests.Interfaces
{
    // default Modifier of intefaces

    public interface IInterface1
    {
         void GetEmployee();
    }

    public interface IInterface2
    {
         void GetEmployee();
    }
    class TestInterfaces : IInterface1, IInterface2
    {
         void IInterface1.GetEmployee()
        {
            Console.WriteLine("IInterface1.GetEmployee");
        }
         void IInterface2.GetEmployee()
        {
            Console.WriteLine("IInterface1.GetEmployee");
        }
    }
}
