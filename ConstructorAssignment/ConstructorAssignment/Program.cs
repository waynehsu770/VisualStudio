using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string welcome_message = "Welcome to the program"; // Constant variable
            Console.WriteLine(welcome_message);
            Console.WriteLine("Please enter your name: ");
            var user_name = Console.ReadLine();
            Console.WriteLine("Welcome, {0}", user_name);

            User newUser = new User();
            Console.WriteLine(newUser.FirstName + " " + newUser.LastName);

            Console.Read();
        }
    }
}
