using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    class Person
    {
        protected string Name;
        protected string Address;

        public Person()
        {
            Name = "PlaceholderName";
            Address = "PlaceHolderAddress";

        }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public string ToStringMethod()
        {
            return ($"Name: {Name} \n" +
                $"Address: {Address}");
        }


    }
}
