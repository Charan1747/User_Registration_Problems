using System;
using System.Text.RegularExpressions;

namespace UserValidations
{
    class ValidEmail
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Email :");
            String email = (Console.ReadLine());
            if (email.Length >= 3)
            { 
                Regex reg = new Regex("^[a-z+0-9+.]+@[a-z.]+[a-z]+$");
                Match match = reg.Match(email);
                if(match.Success)
                    Console.WriteLine("" +email + " is" + " Valid E-mail");
                else
                    Console.WriteLine(""+email+ " is" + " Invalid Email");
            }
            else
                Console.WriteLine(""+email+ " is" + " Invalid Email");
        }
    }
}
 