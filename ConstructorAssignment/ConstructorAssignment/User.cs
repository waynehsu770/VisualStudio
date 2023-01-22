using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class User
    {
        public string FirstName;
        public string LastName;

        public User() : this("Guest", "") // Chaining the constructors with default values
        {
            
        }

        public User(string Firstname, string LastName)
        {
            this.FirstName = Firstname;
            this.LastName = LastName;
        }

    }
}
