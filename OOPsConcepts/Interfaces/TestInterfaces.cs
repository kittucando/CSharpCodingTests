using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts.Interfaces
{


    public interface IInterface1
    {
        public void getEmployee();
    }

    public interface IInterface2
    {
        public void getEmployee();
    }
    class TestInterfaces : IInterface1, IInterface2
    {

       

        
    }
}
