using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime); // Prints current time

            Console.WriteLine("Please enter a number: ");
            int user_input = Convert.ToInt32(Console.ReadLine());

            DateTime newTime = dateTime.AddHours(user_input);
            Console.WriteLine(newTime);

            Console.Read();
        }
    }
}
