using System;

namespace CSharpExamples
{
    class Customer

    {

        private string name;

        // Properties

        public int CustomerID { get; set; }

        //This will encapsulate the private variable name. name can only accessed from this property from other classes.

        public string Name

        {

            get

            {

                return name;

            }

            set

            {

                name = value;

            }

        }

        //Indexer

        private string[] purchasedItem = new string[10];

        public string this[int i]

        {

            get

            {

                return purchasedItem[i];

            }

            set

            {

                purchasedItem[i] = value;

            }

        }

        public int Length

        {

            get { return purchasedItem.Length; }

        }

        // Constructor

        public Customer(int ID, string name)

        {

            Name = name;

            CustomerID = ID;

        }

        // .. Additional methods, events, etc.

    }

    // Test class

    class Program

    {

        static void Main(string[] args)

        {

            //Using User defined constructor

            Customer cust = new Customer(1, "Aashish");



            //Adding purchased items to demonstrate Indexer

            for (int i = 0; i < 10; i++)

            {

                cust[i] = "Item" + i;

            }

            Console.WriteLine("The customer Name is " + cust.Name + " And ID is " + cust.CustomerID);

            Console.WriteLine(cust.Name + " Purchased following items");

            for (int j = 0; j < cust.Length; j++)

            {

                Console.WriteLine(cust[j]);

            }

            Console.ReadLine();

        }

    }

}

