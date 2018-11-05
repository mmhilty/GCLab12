using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    class Student : Person, IComparable
    {
        public string Program;
        public int Year;
        public double Fee;
        public int FinalScore;
        
        public Student(string FirstName, string LastName, string Address, string Program, int Year, double Fee) : base(FirstName, LastName, Address)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
            this.FinalScore = -1;
        }



        public Student()
        {
            FirstName = "DefaultFirst";
            LastName = "DefaultLast";
            Address = "DefaultAddress";
            Program = "DefaultProgram";
            Year = -1;
            Fee = -1;
        }
            
        public string ReturnName()
        {
            return ($"{FirstName} {LastName}");
        }

        public string ReturnLastName()
        { return LastName; }

        public override string ToString()
        {
            return ($"\n====================================================================\n" +
                $"Student Record\n" +
                $"====================================================================\n" +
                $"  Name: {FirstName} {LastName} \n" +
                $"  Address: {Address} \n" +
                $"  Program: {Program} \n" +
                $"  Year: {Year}\n" +
                $"  Fee: {Fee}\n" +
                "====================================================================\n");

        }

        public virtual int CompareTo(object obj)
        {
            Student student = (Student)obj;
            return LastName.CompareTo(student.LastName);
        }

    }
}
