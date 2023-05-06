using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {   // Must have 1 special char
        try
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (!IsValidPassword(password))
            {
                throw new Exception("Invalid password entered.");
            }

            Console.WriteLine("Valid password entered: " + password);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static bool IsValidPassword(string password)
    {
        string regexPattern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[@#$%^&+=!])[^\\s]{8,}$";

        bool isMatch = Regex.IsMatch(password, regexPattern);

        return isMatch;
    }
}
