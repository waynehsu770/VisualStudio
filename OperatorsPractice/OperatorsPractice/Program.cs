using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee_1 = new Employee();
            Employee_1.FirstName = "Sam";
            Employee_1.LastName = "Johnson";
            Employee_1.Id = 1;
            Employee Employee_2 = new Employee();
            Employee_2.FirstName = "Jessica";
            Employee_2.LastName = "Haze";
            Employee_2.Id = 2;

            Console.WriteLine(Employee_1 == Employee_2);
            Console.WriteLine(Employee_1 != Employee_2); 

            Console.ReadLine();
        }
    }
}
