using System;
using System.Text.RegularExpressions;

namespace EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emails = { "sample@mail.com", "sample.mail.com", "sample@mail" };

            foreach (string email in emails)
            {
                try
                {
                    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                    if (!regex.IsMatch(email))
                    {
                        throw new Exception($"Error: {email} is not a valid email address.");
                    }

                    Console.WriteLine($"Success: {email} is a valid email address.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }   
}