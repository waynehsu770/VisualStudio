using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee();
            sample.firstName = "Sample";
            sample.lastName = "Student";
            sample.SayName();

            Console.ReadLine();
        }
    }
}
