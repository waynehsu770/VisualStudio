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
            math.multiplication(2, 5);
            math.multiplication(a: 4, b: 7); // Call the method and specify the name of the parameters

            Console.ReadLine();
        }
    }
}
