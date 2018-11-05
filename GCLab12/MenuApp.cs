using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    public class MenuApp
    {
        public static void MenuMethod()
        {
            {
                List<Staff> staffDirectoryList = new List<Staff>();
                List<Student> studentDirectoryList = new List<Student>();
                studentDirectoryList.Add(new Student("FirstName","LastName","Address","Program", 2001, 39000));
                studentDirectoryList.Add(new Student("Keene","Lynx","45 Which Way","Hexes", 2020, 4000));
                studentDirectoryList.Add(new Student("Dallan","Discord","88 Dat Way","Curses", 2020, 4040));
                studentDirectoryList.Add(new Student("Streetlamp","LeMoose","0 Iwanitdat Way","Hexes", 2021, 4000));
                studentDirectoryList.Add(new Student("Regina","Chalice","Palace","Potions", 2022, 5000));
                studentDirectoryList.Add(new Student("Lucretia","Borgia","Venice","Potions", 2021, 5000));
                studentDirectoryList.Add(new ArchivedStudent("Vampirella", "Carpathian", 92));
                studentDirectoryList.Add(new ArchivedStudent("Kazul", "King of the Dragons", 101)); 
                studentDirectoryList.Add(new ArchivedStudent("Bramble", "Proudfoot", 75));
                studentDirectoryList.Sort();

                bool killswitch = true;
                while (killswitch)
                {
                    Console.WriteLine("Menu Options:\n" +
                        "1. Add Student(Active)\n" +
                        "2. Add Student(Archived)\n" +
                        "3. Add Staff Member\n" +
                        "4. View Student Directory\n" +
                        "5. View Staff Directory\n" +
                        "6. Quit\n");
                    int menuChoice = (int)(Validation.NumberVal("What would you like to do?"));

                    switch (menuChoice)
                    {
                        case 1: // add Student
                            studentDirectoryList = ContentManage.AddStudentRecord(studentDirectoryList);
                            break;
                        case 2: // add  ArchivedStudent
                            studentDirectoryList = ContentManage.AddArchiveStudentRecord(studentDirectoryList);
                            break;
                        case 3: // add Staff
                            staffDirectoryList = ContentManage.AddStaffRecord(staffDirectoryList);
                            break;
                        case 4: // view students
                            ContentManage.viewStudentList(studentDirectoryList);
                            Console.WriteLine(ContentManage.ViewStudentRecord(studentDirectoryList));
                            break;
                        case 5: // view staff
                            break;
                        case 6:
                            killswitch = false;
                            break;
                        default:
                            break;

                    }

                    
                }
            }
        }
    }
}

