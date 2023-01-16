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

        public int subtraction(decimal data)
        {
            decimal decimal_answer = data - 2;
            int subtraction_answer = Decimal.ToInt32(decimal_answer);
            return subtraction_answer;
        }

        public int subtraction(string data)
        {
            int number = Convert.ToInt32(data);
            int subtraction_answer = number - 4;
            return subtraction_answer;
        }
    }
}
