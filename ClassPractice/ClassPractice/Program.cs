using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please enter a number: ");
            int user_input = Convert.ToInt32(Console.ReadLine());
            int answer_1 = math.multiplication(user_input);
            int answer_2 = math.division(user_input);
            int answer_3 = math.addition(user_input);
            Console.WriteLine(user_input + " multiplied by 2 is: " + answer_1);
            Console.WriteLine(user_input + " divided by 2 is: " + answer_2);
            Console.WriteLine(user_input + " plus 1 is: " + answer_3);

            Console.ReadLine();
        }
    }
}
