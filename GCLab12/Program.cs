using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    class Program
    {
        static void Main(string[] args)
        {

            Person Fred = new Person("Fred", "123 Blank Lane");
            Person TestPerson = new Person();
            Student Carter = new Student("Carter", "13 Bad Luck Drive", "Kindergarten", 2020, 1000);
            Student TestStudent = new Student();
            Staff Winkleman = new Staff("Mr Winkleman", "39 Peachtree Lane", "Peachtree Montessori", 50000);
            Staff TestStaff = new Staff();

            Console.WriteLine(Fred.ToStringMethod() + "\n");
            Console.WriteLine(TestPerson.ToStringMethod() + "\n");
            Console.WriteLine(Carter.ToStringMethod() + "\n");
            Console.WriteLine(TestStudent.ToStringMethod() + "\n");
            Console.WriteLine(Winkleman.ToStringMethod() + "\n");
            Console.WriteLine(TestStaff.ToStringMethod() + "\n");

        }
    }
}
