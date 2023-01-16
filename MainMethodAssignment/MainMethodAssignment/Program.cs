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
            int answer = math.subtraction(8);
            int answer_2 = math.subtraction((decimal)6.2);
            int answer_3 = math.subtraction("10");
            Console.WriteLine(answer);
            Console.WriteLine(answer_2);
            Console.WriteLine(answer_3);

            Console.ReadLine();
        }
    }
}
