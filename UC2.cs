using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        string pattern = @"^[A-Z][a-z]{2,}$";

        if (Regex.IsMatch(lastName, pattern))
        {
            Console.WriteLine("Valid last name entered: " + lastName);
        }
        else
        {
            Console.WriteLine("Invalid last name entered. Last name should start with a capital letter and have at least 3 characters.");
        }
    }
}
