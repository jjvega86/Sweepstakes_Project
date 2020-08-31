using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class ApplicationInterface
    {
        public static string GetFirstName()
        {
            Console.WriteLine("Please type your first name!");
            string input = Console.ReadLine();

            return input;
        }

        public static string GetLastName()
        {
            Console.WriteLine("Please type your last name!");
            string input = Console.ReadLine();

            return input;
        }

        public static string GetEmailAddress()
        {
            Console.WriteLine("Please type your email address!");
            string input = Console.ReadLine();

            return input;
        }

        public static int AssignRegistrationNumber()
        { // could create a method to validate new random number to ensure no duplicates

            Random random = new Random();
            return random.Next(0, 10000);           
        }
    }
}
