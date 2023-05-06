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

            try
            {
                //Must contain at least one numeric number
                Regex regex = new Regex(@"^(?=.*\d)(?!.*[^\w\s])(?!.*[_]).{8,}$");

                if (regex.IsMatch(password))
                {
                    Console.WriteLine("Success: Valid password.");
                }
                else
                {
                    throw new Exception("Error: Invalid password.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}