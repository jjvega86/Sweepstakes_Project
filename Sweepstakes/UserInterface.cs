using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine(prompt);
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
