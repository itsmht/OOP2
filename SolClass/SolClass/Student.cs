using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolClass
{
    class Student
    {
        private String name;
    private int id;
    private String faculty;
    private double cgpa;
    

public Student(String n, int i, String fa, double cg){
    name = n;
    id = i;
    faculty = fa;
    cgpa = cg;
}


public void showInfo()
{
    Console.WriteLine("Name: " + name);
    Console.WriteLine("ID: " + id);
    Console.WriteLine("Faculty: " + faculty);
    Console.WriteLine("CGPA: " + cgpa);
}

}
}



