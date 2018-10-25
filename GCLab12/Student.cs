using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    class Student : Person
    {
        private string Program;
        private int Year;
        private double Fee;

        public Student(string Name, string Address, string Program, int Year, double Fee) : base(Name, Address)
        {
            this.Name = Name;
            this.Address = Address;
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }

        public Student()
        {
            Name = "DefaultName";
            Address = "DefaultAddress";
            Program = "DefaultProgram";
            Year = -1;
            Fee = -1;              
        }

        public new string ToStringMethod()
        {
            return ($"Name: {Name} \n" +
                $"Address: {Address} \n" +
                $"Program: {Program} \n" +
                $"Year: {Year}\n" +
                $"Fee: {Fee}");
        }

    }
}
