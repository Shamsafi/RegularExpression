using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            //Rules
            //Should not start with a digit or special character
            //Should not end with a special character
            //Must contain at least one uppercase letter
            //Must contain at least one lowercase letter
            // Must contain at least one digit

            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?!.*[^\w\s]).{8,}$");


            if (regex.IsMatch(password))
            {
                Console.WriteLine("Success: Valid password.");
            }
            else
            {
                Console.WriteLine("Error: Invalid password.");
            }
        }
    }
}