using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol8
{
    class Program
    {
        static void Main(string[] args)
        {
            float physics = 90f;
            float chem = 87f;
            float bio = 76f;
            float math = 95f;
            float comp = 99f;
            float result = (physics + chem + bio + math + comp) / 5;
            Console.WriteLine("Total Marks " +result);
            if (result >= 90) { Console.WriteLine("Grade A+"); }
            else if (result >= 85 && result < 90) { Console.WriteLine("Grade A"); }
            else if (result >= 80 && result < 85) { Console.WriteLine("Grade B+"); }
            else if (result >= 75 && result < 80) { Console.WriteLine("Grade B"); }
            else if (result >= 50 && result < 75) { Console.WriteLine("Grade C+"); }
            else { Console.WriteLine("Grade F"); }
        }
    }
}
