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

        public Staff(string Name, string Address, string School, double Pay) : base(Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }

        public Staff()
        {
            Name = "DefaultName";
            Address = "Default Address";
            School = "Default School";
            Pay = -1;
                
        }

        public new string ToStringMethod()
        {
            return ($"Name: {Name} \n" +
                $"Address: {Address}\n" +
                $"School: {School}\n" +
                $"Pay: {Pay}");
        }



    }
}
