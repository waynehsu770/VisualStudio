using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee(); // Instantiate the object
            sample.FirstName = "Sample";
            sample.LastName = "Student";
            sample.SayName(); // Call the superclass method that Employee inherited from Person

            sample.Id = 1;
            sample.SayId();

            Console.ReadLine();
        }
    }
}
