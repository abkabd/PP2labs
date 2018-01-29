using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student("Roman", "Savoskin", 17);
            Student s3 = new Student();
            s3.ReadStudent();
            
            Console.WriteLine("{0} \n{1} \n{2} \n", s1, s2, s3);

        }
    }
}
