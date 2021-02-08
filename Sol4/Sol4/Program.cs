using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int e = 0;
            int o = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    e = e + i;
                }
                else
                {
                    o = o + i;
                }
            }
            Console.WriteLine(e);
            Console.WriteLine(o);
        }
    }
}
