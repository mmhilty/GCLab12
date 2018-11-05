using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    class ArchivedStudent : Student, IComparable
    {
        public new int FinalScore;

        public ArchivedStudent(string FirstName, string LastName, int FinalScore)
        { 
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.FinalScore = FinalScore;
        }

        public override string ToString()
        {
            return ($"\n====================================================================\n" +
                $"Student Record\n" +
                $"====================================================================\n" +
                $"  Name: {FirstName} {LastName} \n" +
               $"  Final Score: {FinalScore} \n" +
               $"====================================================================\n");
              
        }

       


        public override int CompareTo(object obj)
        {
            Student student = (Student)obj;
            return LastName.CompareTo(student.LastName);
        }
        
    }
}
