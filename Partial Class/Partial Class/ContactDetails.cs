using System;
using System.Collections.Generic;
using System.Text;

namespace Partial_class
{
    public partial class Person
    {
        public string Email { get; set; }
        public string Number { get; set; }

        public void ContactDetails()
        {
            Console.WriteLine($"Email:{Email}, Number:{Number}");
        }

    }
}
