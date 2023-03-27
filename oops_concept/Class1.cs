using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept
{

    public class Class1
    {
             public void method1()
            {
            var obj1 = new test1();
            obj1.method2();
                Console.WriteLine("printing from method1");
            }
        private class test1
        {
            protected internal void method2() 
            {
                Console.WriteLine("printing from test1");
            }
        }
        }
    }



