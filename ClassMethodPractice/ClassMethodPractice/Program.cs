using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please enter a number: ");
            int user_number = Convert.ToInt32(Console.ReadLine());
            math.division(user_number);
            Math.addition(out int c);
            Math.addition(user_number, out int d);

            Console.ReadLine();
        }
    }
}
