using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    internal class Program
    {
        // <summary>
        // Validating Password Rule 4
        // </summary>
        /// <param name="args">The args.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program\n");
            UserRegistration userRegistration = new UserRegistration();      // Declaring object
            Console.WriteLine("Enter valid first name");
            string firstname = Console.ReadLine();
            userRegistration.ValidateFName(firstname);

        }
    }
}
