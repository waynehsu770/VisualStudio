﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Employee : Person
    {
        public int Id;

        public void SayId()
        {
            Console.WriteLine("Id: " + Id);
        }
    }
}