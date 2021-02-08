using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolClass
{
    class Triangle
    {
        private int x;
        private int y;
        private int z;


        public Triangle(int xx,int yy, int zz)
    {
        x = xx;
        y = yy;
        z = zz;
    }
        public void TestTriangle()
        {
            if (x == y && x == z && y==z) { Console.WriteLine("Equilateral ");}
            else if (x == (y + z)) { Console.WriteLine("Isosceles"); }
            else { Console.WriteLine("Scalene "); }
        }

    }
}
