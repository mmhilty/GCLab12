using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    class Staff : Person
    {
        private string School;
        private double Pay;

        public Staff(string FirstName, string LastName, string Address, string School, double Pay) : base(FirstName, LastName, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }

        public Staff()
        {
            FirstName = "DefaultFirst";
            LastName = "DefaultLast";
            Address = "Default Address";
            School = "Default School";
            Pay = -1;
                
        }

        public new string ToStringMethod()
        {
            return ($"Name: {FirstName} {LastName}\n" +
                $"Address: {Address}\n" +
                $"School: {School}\n" +
                $"Pay: {Pay}");
        }



    }
}
