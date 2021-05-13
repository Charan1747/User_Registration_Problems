using System;
using System.Text.RegularExpressions;

namespace UserPassword
{
    class Password
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Password:");
            string password = (Console.ReadLine());
            if (password.Length >= 8)
            { 
                Regex reg = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&-+=()])(?=\\S+$)");
                Match match = reg.Match(password);
                if (match.Success)
                        Console.WriteLine("" + password + " is" + " Valid Password");
                else
                        Console.WriteLine("" + password + " is" + " Invalid Password");
            }
            else
                Console.WriteLine(""+ password + " is" + " Invalid Password");
        }
    }
}
 