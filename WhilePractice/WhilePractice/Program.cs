using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            int b = 0;
            do
            {
                Console.WriteLine("b = " + b);
                b++;
            } while (b <= 10);
            Console.Read();
        }
    }
}
