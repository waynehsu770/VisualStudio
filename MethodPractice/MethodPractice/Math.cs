using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    public class Math
    {
        public int math_operation(int a, int b = 0) // b is the optional parameter
        {
            int answer = a + b;
            return answer;
        }
    }
}
