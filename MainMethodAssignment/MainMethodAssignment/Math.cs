using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Math
    {
        public int subtraction(int data)
        {
            int subtraction_answer = data - 1;
            return subtraction_answer;
        }

        public int subtraction(decimal data) // First method overload
        {
            decimal decimal_answer = data - 2;
            int subtraction_answer = Decimal.ToInt32(decimal_answer); // Converts answer from decimal to int
            return subtraction_answer;
        }

        public int subtraction(string data) // Second method overload
        {
            int number = Convert.ToInt32(data);
            int subtraction_answer = number - 4;
            return subtraction_answer;
        }
    }
}
