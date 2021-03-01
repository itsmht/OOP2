using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Talha", "39597", 3.61f);
            Student s2 = new Student("Piya", "39598", 2.77f);
            Department d1 = new Department("Science & Technology", "CS");
            Department d2 = new Department("Social Science", "SS");
            s1.Dept = d1;
            s2.Dept = d2;
            s1.ShowDeptInfo();
            Console.WriteLine("*******");
            d1.AddStudent(s1);
            d1.AddStudent(s2);

            d1.Print();
        }
    }
}
