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

            DaysOfTheWeek user_input = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), "Monday, Tuesday");
            Console.WriteLine(user_input);

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
