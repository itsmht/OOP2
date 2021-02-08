using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj1 = new Student("Mehedi Hasan Talha", 39597, "FST", 3.61);
            //Student obj2 = new Student("Shahed Shourav", 39595, "FST", 3.50);
            obj1.showInfo();
            //obj2.showInfo();
            Account obj3 = new Account("Mehedi Hasan Talha", "39597", 50000);
            obj3.Deposit(500);
            Course obj4 = new Course("OOP 2", "CSC3203", 3);
            obj4.ShowCourseInfo();
            Triangle obj5 = new Triangle(2,2,2);
            obj5.TestTriangle();
        }
    }
}
