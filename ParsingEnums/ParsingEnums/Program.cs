using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week: ");
            string user_day = Console.ReadLine();

            try
            {
                DaysOfTheWeek user_input = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), user_day);
                Console.WriteLine(user_input);
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter an actual day of the week.");
            }

            Console.Read();

        }

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
