using System;
using System.Text.RegularExpressions;

namespace UserValidations
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Last Name :");
            String last_name = (Console.ReadLine());
            if (last_name.Length >= 3)
            { 
                Regex reg = new Regex(@"^[A-Z]");
                Match match = reg.Match(last_name);
                if(match.Success)
                    Console.WriteLine("Valid Last Name");
                else
                    Console.WriteLine("Invalid Last Name");
            }
            else
                Console.WriteLine("Invalid Last Name");
        }
    }
}
