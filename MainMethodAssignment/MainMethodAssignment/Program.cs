using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            int answer = math.subtraction("8");
            Console.WriteLine(answer);

            Console.ReadLine();
        }
    }
}
