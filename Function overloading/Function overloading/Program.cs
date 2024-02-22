using System;

namespace Function_overloading
{
    internal class Program
    {
        void printarea(int l)
        {
            Console.WriteLine("The area of square=" + l * l);
        }
        void printarea1(int l, int b)
        {
            Console.WriteLine("The area of Rectangle:" + l * b);

        }
        static void Main(string[] args)
        {
           Program p = new Program();
            p.printarea(5);
            p.printarea1(5, 10);

        }
    }
}
