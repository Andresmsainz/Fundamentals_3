using System;

namespace Fundamentals_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Fundamentals Part 3!");
            Console.WriteLine("Try Parse... Could be an int or it could not!");
            Console.WriteLine("Please input an int higher than 0");
            int.TryParse(Console.ReadLine(), out int x);

            if (x==0)
            {
                Console.WriteLine("This is not valid");
            }
            else
            {
                Console.WriteLine("You have entered " + x);
            }
        }
    }
}
