using System;

namespace Fundamentals_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Fundamentals Part 3!");
            bool bTryParse = false;
            bool bConstants = true;

            //Try Parse
            if (bTryParse == true)
            {
                Console.WriteLine("Try Parse... Could be an int or it could not!");
                Console.WriteLine("Please input an int higher than 0");
                int.TryParse(Console.ReadLine(), out int x);

                if (x == 0)
                {
                    Console.WriteLine("This is not valid");
                }
                else
                {
                    Console.WriteLine("You have entered " + x);
                }
            }
            else
            {
                Console.WriteLine("Skipping TryParse per Configuration");
            }

            //Constants Section
            if (bConstants == true)
            {
                Console.WriteLine("Constants... Values are not allowed to change!");

                const double dblGravityForce = 9.8;
                const double dblPI = 3.14159265359;

                Console.WriteLine("Gravity Force is " + dblGravityForce + " & PI is " + dblPI);
            }
            else
            {
                Console.WriteLine("Skipping Constants per Configuration");
            }

            //Next Section
            //Next Section
            //Next Section
            //Next Section
            //Next Section
            //Next Section


        }
    }
}
