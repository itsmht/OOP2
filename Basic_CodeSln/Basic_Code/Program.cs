using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 50, y = 2;
            int add = x + y;
            int sub = x - y;
            int mult = x * y;
            int div = x / y;
            Console.WriteLine("Addition is " +add);
            Console.WriteLine("Substraction is " + sub);
            Console.WriteLine("Multiplication is " + mult);
            Console.WriteLine("Division is " + div);
            string a = Console.ReadLine();
            int R = Int32.Parse(a);
            Console.WriteLine(R);
        }
    }
}
