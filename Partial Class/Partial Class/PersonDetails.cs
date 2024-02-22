using System;
using System.Collections.Generic;
using System.Text;

namespace Partial_class
{
    public partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void PersonDetails()
        {
            Console.WriteLine($"Name:{FirstName} {LastName}, Age:{Age}");

        }
    }
}
