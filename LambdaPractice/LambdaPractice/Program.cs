using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee_list = new List<Employee>();
            Employee employee_1 = new Employee();
            employee_1.Id = 1;
            employee_1.FirstName = "Joe";
            employee_1.LastName = "Johnson";
            employee_list.Add(employee_1);

            Employee employee_2 = new Employee();
            employee_2.Id = 2;
            employee_2.FirstName = "Joe";
            employee_2.LastName = "Jefferson";
            employee_list.Add(employee_2);

            Employee employee_3 = new Employee();
            employee_3.Id = 3;
            employee_3.FirstName = "Randy";
            employee_3.LastName = "Moss";
            employee_list.Add(employee_3);

            Employee employee_4 = new Employee();
            employee_4.Id = 4;
            employee_4.FirstName = "Emily";
            employee_4.LastName = "Olbec";
            employee_list.Add(employee_4);

            Employee employee_5 = new Employee();
            employee_5.Id = 5;
            employee_5.FirstName = "Mandy";
            employee_5.LastName = "Chang";
            employee_list.Add(employee_5);

            Employee employee_6 = new Employee();
            employee_6.Id = 6;
            employee_6.FirstName = "Brandon";
            employee_6.LastName = "Lang";
            employee_list.Add(employee_6);

            Employee employee_7 = new Employee();
            employee_7.Id = 7;
            employee_7.FirstName = "Christine";
            employee_7.LastName = "Shum";
            employee_list.Add(employee_7);

            Employee employee_8 = new Employee();
            employee_8.Id = 8;
            employee_8.FirstName = "Donald";
            employee_8.LastName = "Reed";
            employee_list.Add(employee_8);

            Employee employee_9 = new Employee();
            employee_9.Id = 9;
            employee_9.FirstName = "Irene";
            employee_9.LastName = "Kobolt";
            employee_list.Add(employee_9);

            Employee employee_10 = new Employee();
            employee_10.Id = 10;
            employee_10.FirstName = "Gwendolyn";
            employee_10.LastName = "Chess";
            employee_list.Add(employee_10);


            Console.WriteLine("The number of employees is: " + employee_list.Count);

            foreach (Employee employee in employee_list)
            {
                Console.WriteLine(employee);
                Console.WriteLine();
            }

            Console.WriteLine("Duplicate First Name Employees: \r\n");

            List<Employee> duplicate_list = new List<Employee>();

            foreach (Employee employee in employee_list)
            {
                if (employee.FirstName == "Joe")
                {
                    duplicate_list.Add(employee);
                }
            }

            foreach (Employee employee in duplicate_list)
            {
                Console.WriteLine(employee);
                Console.WriteLine();
            }

            Console.WriteLine("Duplicate First Name Employees Using Lambda: \r\n");

            List<Employee> firstname_list = employee_list.Where(y => y.FirstName == "Joe").ToList();

            foreach (Employee employee in firstname_list)
            {
                Console.WriteLine(employee);
                Console.WriteLine();
            }

            Console.WriteLine("Employees with Id greater than 5: \r\n");

            List<Employee> Id_list = employee_list.Where(x => x.Id > 5).ToList();

            foreach(Employee employee in Id_list)
            {
                Console.WriteLine(employee);
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}
