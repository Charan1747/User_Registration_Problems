using System;
using System.Text.RegularExpressions;

namespace UserValidations
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name :");
            String first_name = (Console.ReadLine());
            if (first_name.Length >= 3)
            { 
                Regex reg = new Regex(@"^[A-Z]");
                Match match = reg.Match(first_name);
                if(match.Success)
                    Console.WriteLine("Valid User Name");
                else
                    Console.WriteLine("Invalid User Name");
            }
            else
                Console.WriteLine("Invalid User Name");
        }
    }
}
