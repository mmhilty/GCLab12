using System;
using System.Collections;
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

            ArrayList directoryArrayList = new ArrayList();
            List<Staff> staffDirectoryList = new List<Staff>();
            List<Student> studentDirectoryList = new List<Student>();

            // main menu
            // view record
            // edit record
            // add record
            Console.WriteLine("What type of record would you like to add?\n" +
                "1. Student \n" +
                "2. Staff");
            string userType = Console.ReadLine();
            //if (userType == "1")
                // delete record


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
