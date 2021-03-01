using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Department
    {
        private string deptName;

        public string dName
        {
            get { return deptName; }
            set { deptName = value; }
        }
        private string deptID;

        public string dId
        {
            get { return deptID; }
            set { deptID = value; }
        }
        private int studentCount;

        public int sCount
        {
            get { return studentCount; }
            set { studentCount = value; }
        }
         
        private Student[] students;

        public Department()
        {
            students = new Student[50];
        }
        public Department(string deptName, string deptID)
        {
            this.deptName = deptName;
            this.deptID = deptID;
            students = new Student[50];
        }
        public void AddStudent(params Student[] stu)
        {
            foreach(Student s in stu)
            {
                students[studentCount++] = s;
                s.Dept = this;
            }
        }
       public void Print()
        {
           foreach(Student s in students)
           {
               s.ShowInfo();
           }
        }
        public void ShowInfo()
       {
           Console.WriteLine("Dept Name : " + deptName);
           Console.WriteLine("Dept Id : " + deptID);
       }
        
        
    }
}
