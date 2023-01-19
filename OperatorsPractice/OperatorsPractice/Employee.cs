using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsPractice
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public int Id;

        public static bool operator ==(Employee Employee_1, Employee Employee_2) // Overload the == operator
        {
            if(Employee_1.Id == Employee_2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee Employee_1, Employee Employee_2) // Overload the != operator 
        {
            if(Employee_1.Id != Employee_2.Id)
            {
                return true;;
            } else
            {
                return false;
            }

        }
    }
}
