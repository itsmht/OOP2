using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        private Department dept;
        public Department Dept
        {
            set { this.dept = value; }
            get { return this.dept; }
        }
        public Student(string name, string id , float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID : " + id);
            Console.WriteLine("CGPA : " + cgpa);
        }
        public void ShowDeptInfo()
        {
            ShowInfo();
            Dept.ShowInfo();
        }
        
        
        
        
    }
}
