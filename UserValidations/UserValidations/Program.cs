using System;
using System.Text.RegularExpressions;

namespace UserValidations
{
    class ValidEmail
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Phone Number :");
            String Ph_no = (Console.ReadLine());
            if (Ph_no.Length == 13)
            { 
                Regex reg = new Regex(@"^(91)[ ]{1}[7-9]{1}[0-9]{9}");
                Match match = reg.Match(Ph_no);
                if(match.Success)
                    Console.WriteLine("" +Ph_no + " is" + " Valid Phone Number");
                else
                    Console.WriteLine("" +Ph_no + " is" + " Invalid Number");
            }
            else
                Console.WriteLine("" +Ph_no + " is" + " Invalid Phone Number");
        }
    }
}
 