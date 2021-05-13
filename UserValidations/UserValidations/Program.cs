using System;
using System.Text.RegularExpressions;

namespace UserValidations
{
    class Password
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Password:");
            string password = (Console.ReadLine());
            if (password.Length >= 8)
            {
                Console.WriteLine("Valid Password");
            }
            else
                Console.WriteLine("invalid input ");
        }
    }
}
 