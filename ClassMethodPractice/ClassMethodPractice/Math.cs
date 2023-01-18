using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodPractice
{
    public class Math
    {
        public void division(int a)
        {
            int answer = a / 2;
            Console.WriteLine(a + " divided by 2 equals: " + answer);
        }

        public static void addition(out int b)
        {
            int answer = 2 + 3;
            b = answer;
            Console.WriteLine(b);
        }

        public static void addition(int a, out int b)
        {
            int answer = a + 7;
            b = answer;
            Console.WriteLine(b);
        }
    }
}
