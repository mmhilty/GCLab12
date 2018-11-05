using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    class Person
    {
        protected string FirstName;
        internal string LastName;
        protected string Address;


        public Person()
        {
            FirstName = "PlaceholderFirst";
            LastName = "PlaceholderLast";
            Address = "PlaceHolderAddress";

        }

        public Person(string firstName, string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public override string ToString()
        {
            return ($"Name: {FirstName} {LastName}\n" +
                $"Address: {Address}");
        }

        
    }
}
