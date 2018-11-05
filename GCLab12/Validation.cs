using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GCLab12
{
    class Validation
    {

        public static string GetInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
          
        }

        public static string letterVal(string message)
        {
            Console.WriteLine(message);
            string InputString = Console.ReadLine();

            while (true)
            {
                if (Regex.IsMatch(InputString.ToLower(), @"^[a-z]\w") )
                {
                    return (InputString);
                }

                else
                {
                    Console.WriteLine("Invalid Input. Please make sure your entry has no numbers in it.");

                }

                InputString = Console.ReadLine();
            }

        }
               
        public static double NumberVal(string message)
        {
            Console.WriteLine(message);
            string NumberString = Console.ReadLine();
            double NumberDouble;

            while (true)
            {
                if (double.TryParse(NumberString, out NumberDouble))
                {
                    return NumberDouble;
                }

                else
                {
                    Console.WriteLine("Invalid input. Please make sure your input only contains numbers.\n" +
                        "Please try again");
                }

                NumberString = Console.ReadLine();

            }
        }

        public static double NumberVal(string message, int MaxNumber)
        {
            Console.WriteLine(message);
            string NumberString = Console.ReadLine();
            double NumberDouble;

            while (true)
            {
                if (double.TryParse(NumberString, out NumberDouble) && NumberDouble > 0 && NumberDouble <= MaxNumber)
                {
                    return NumberDouble;
                }

                else
                {
                    Console.WriteLine("Invalid input. Please make sure your input only contains numbers between 0 and 100.\n" +
                        "Please try again");
                }

                NumberString = Console.ReadLine();

            }
        }




    }
        }
      
    
