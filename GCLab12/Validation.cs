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

        public static string letterVal(string inputstring)
        {
            string InputString = inputstring;

            while (true)
            {
                if (Regex.IsMatch(InputString.ToLower(), @"^[aeiou]") && !(Regex.IsMatch(InputString, @"[0-9]")))
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
               
        public static double NumberVal(string numberString)
        {
            string NumberString = numberString;
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

       


            }
        }
      
    
