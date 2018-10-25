using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    class ContentManage
    {
        // using lists

        // create entry

        //public static List<> ListCreate(List<> inputList)
        //{
        //    ask user for fields
        //    create object from fields
        //    add object to list
        //    return the list plus the object
        //}

        

        public static List<Student> AddStudentRecord(List<Student> studentDirectoryList)
        {
                Console.WriteLine($"Now adding a student:\n");
                string Name = Validation.letterVal("What is the student's name?");
                string Address = Validation.letterVal("What is the student's address");
                string Program = Validation.letterVal("What study program is the student part of?");
                int Year = Convert.ToInt32((Validation.NumberVal("What year will the student graduate?")));
                double Fee = (Validation.NumberVal("How much are the school fees?"));
                studentDirectoryList.Add(new Student(Name, Address, Program, Year, Fee));
                Console.WriteLine($"{Name} has been added successfully!");
                return studentDirectoryList;
        }

        public static List<Staff> AddStaffRecord(List<Staff> staffDirectoryList)
        {
            Console.WriteLine($"Now adding a staff member:\n");
            string Name = Validation.letterVal("What is the staff member's name?");
            string Address = Validation.letterVal($"What is {Name}'s address");
            string School = Validation.letterVal("What school do they belong to?");
            double Pay = (Validation.NumberVal($"How much is {Name}'s salary?"));
            staffDirectoryList.Add(new Staff(Name, Address, School, Pay));
            Console.WriteLine($"{Name} has been added successfully!");
            return staffDirectoryList;
        }

        // retrieve entry

        //public static Person searchFunction(List<Student> studentList, List<Staff> staffList)
        //{

        //    List<Student> searchStudents = new List<Student>();
        //    List<Staff> searchStaff = new List<Staff>();

        //    Console.WriteLine("Enter your search term:");
        //    string searchTerm = Console.ReadLine();
            
        //    double searchTermDouble;
        //    if(double.TryParse(searchTerm, out searchTermDouble))
        //    {
        //        foreach (Student s in studentList)
        //        {
        //            if (s.Year.Contains(searchTermDouble))

        //        }
        //    }


        }

          // Your search found {staffSearch.Count} results in Staff Directory:

           // Your search found {studentSearch.Count} results in Student Directory:

        // search function

        // edit entry

        // pull up search to select file
        // display field options to edit
        // edit

        // delete entry

    }

