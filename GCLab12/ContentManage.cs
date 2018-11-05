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
                string FirstName = Validation.letterVal("What is the student's first name?");
                string LastName = Validation.letterVal("What is the student's last?");
                string Address = Validation.letterVal("What is the student's address");
                string Program = Validation.letterVal("What study program is the student part of?");
                int Year = Convert.ToInt32((Validation.NumberVal("What year will the student graduate?")));
                double Fee = (Validation.NumberVal("How much are the school fees?"));
                studentDirectoryList.Add(new Student(FirstName, LastName, Address, Program, Year, Fee));
                Console.WriteLine($"The active student {FirstName} {LastName} has been added successfully!");
                studentDirectoryList.Sort();
                return studentDirectoryList;
        }

        public static List<Student> AddArchiveStudentRecord(List<Student> studentDirectoryList)
        {
            Console.WriteLine($"Now adding an archived student:\n");
            string FirstName = Validation.letterVal("What is the student's first name?");
            string LastName = Validation.letterVal("What is the student's last?");
            int FinalScore = Convert.ToInt32((Validation.NumberVal("What is the student's final score?",100)));
            studentDirectoryList.Add(new ArchivedStudent(FirstName, LastName, FinalScore));
            Console.WriteLine($"The archived student {FirstName} {LastName} has been added successfully!");
            studentDirectoryList.Sort();
            return studentDirectoryList;
        }

        public static List<Staff> AddStaffRecord(List<Staff> staffDirectoryList)
        {
            Console.WriteLine($"Now adding a staff member:\n");
            string FirstName = Validation.letterVal("What is the staff member's first name?");
            string LastName = Validation.letterVal("What is the staff member's last name?");
            string Address = Validation.letterVal($"What is {FirstName}'s address");
            string School = Validation.letterVal("What school do they belong to?");
            double Pay = (Validation.NumberVal($"How much is {FirstName}'s salary?"));
            staffDirectoryList.Add(new Staff(FirstName, LastName, Address, School, Pay));
            Console.WriteLine($"The staff member {FirstName} {LastName} has been added successfully!");
            return staffDirectoryList;
        }

        public static void viewStudentList(List<Student> list)
        {
            int i = 1;
            Console.WriteLine($"\n  {"Name",-30}{"Student Type",-20}{"Final Score",-5}");
            Console.WriteLine("====================================================================");
            foreach (Student s in list)
            {
                
                string x = "";
                if (s.FinalScore != -1)
                {
                    ArchivedStudent y = (ArchivedStudent)s;
                    x = y.FinalScore.ToString();
                }                
                Console.WriteLine($"{i}. {s.ReturnName(),-30}{s.GetType().Name, -20}{x, -5}");
                Console.WriteLine();
                i++;

            }
            Console.WriteLine("====================================================================\n");


        }

        public static string ViewStudentRecord(List<Student> list)
        {
            while (true)
            {
                Console.WriteLine("====================================================================\n");

                Console.WriteLine("Would you like to view a specific record? Y/N");
                string recordChoice = Console.ReadLine().ToUpper();
                switch (recordChoice)
                {
                    case "Y":
                        int choice = Convert.ToInt32(Validation.NumberVal("Please enter the number of the student you want to view:"));
                        return list[choice-1].ToString();


                    case "N":
                        return "";
                    default:
                        Console.WriteLine("Not sure what you mean. Please type Y or N to choose.");
                        break;
                }
            }
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

