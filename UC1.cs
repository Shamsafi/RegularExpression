using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UC1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            if (Regex.IsMatch(firstName, @"^[A-Z][a-z]{2,}$"))
            {
                Console.WriteLine("Success: Valid first name.");
            }
            else
            {
                Console.WriteLine("Error: Invalid first name.");
            }
        }
    }
}