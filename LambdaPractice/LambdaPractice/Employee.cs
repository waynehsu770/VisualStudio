using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPractice
{
    public class Employee
    {
        private int id;
        private string firstName;
        private string lastName;

        public override string ToString()
        {
            return "Employee Id: " + Id + "\nEmployee First Name: " + FirstName + "\nEmployee Last Name: " + LastName;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}
