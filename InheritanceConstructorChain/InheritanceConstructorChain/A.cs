using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorChain
{
    class A
    {
        public A():this(10)
        {
            Console.WriteLine("Default A");

        }
        public A(int a):this(10,12)
        {
            Console.WriteLine("1 parameter: A");
        }
        public A(int a, int b)
        {
            Console.WriteLine("2 parameter: A");
        }
        

    }
}
