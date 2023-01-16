using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            int answer;
            Console.WriteLine("Please input the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Optional: Please input the second number: ");
            int second;
            if (int.TryParse(Console.ReadLine(), out second)) // Checks if user input a number or not
                answer = math.math_operation(first, second);
            else
                answer = math.math_operation(first); // if not only pass through the first user input 


            Console.WriteLine("The answer is: " + answer);

            Console.ReadLine();
        }
    }
}
