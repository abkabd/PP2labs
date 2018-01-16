using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    class Student
    {
        string name;
        string sname;
        double age;

        public Student(string name = "A", string sname = "B", int age = 0)
        {
            this.name = name;
            this.sname = sname;
            this.age = age;
        }

        public void ReadStudent()
        {
            name = Console.ReadLine();
            sname = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return name + " " + sname + " " + age;
        }

        public void PrintStudent()
        {
            Console.WriteLine("{0} {1} {2}", name, sname, age);
        }

    }
}
