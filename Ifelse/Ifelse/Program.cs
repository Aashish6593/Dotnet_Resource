using System;

namespace Ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");

            int input = int.Parse(Console.ReadLine());
            if (int.TryParse(Console.ReadLine(), out input))
            {

                if (input % 2 == 0)
                {
                    Console.WriteLine("The entered number is even");
                }
                else
                {
                    Console.WriteLine("The entered number is odd");
                }
            }
                {
                    Console.WriteLine("The entered letter is invalid");
                }
        }
    
    }
}
