using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math(); // Instantiate the class
            math.multiplication(a: 4, b: 7); // Call the method, can specify parameters by name or not

            Console.ReadLine();
        }
    }
}
