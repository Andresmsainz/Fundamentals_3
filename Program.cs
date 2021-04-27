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
            bool bConstants = false;
            bool bStringManuplation1 = true;

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

                // dblPI = 1; (Trying to change will cause error)

                Console.WriteLine("Gravity Force is " + dblGravityForce + " & PI is " + dblPI);
            }
            else
            {
                Console.WriteLine("Skipping Constants per Configuration");
            }

            //String Manipulation 1 Section
            if (bStringManuplation1 == true)
            {
                Console.WriteLine("String Manipulation 1!");
                string sMovieName = "lord of the rings";
                //Indexes
                Console.WriteLine("The entire name of the movie is " + sMovieName);
                Console.WriteLine("Index 0 is " + sMovieName[0]);
                Console.WriteLine("Index 5 is " + sMovieName[5]);
                Console.WriteLine("Index 5 - 16 is " + sMovieName[5..17]);

                //Trim
                sMovieName = "    lord of the rings     ";
                Console.WriteLine("The entire name of the movie is " + sMovieName);
                Console.WriteLine("The trimmed name of the movie is " + sMovieName.Trim());

                //Upper Case
                sMovieName = "lord of the rings";
                Console.WriteLine("The entire name of the movie is " + sMovieName);
                Console.WriteLine("The upper case name of the movie is " + sMovieName.ToUpper());

                //Lower Case
                sMovieName = "LORD OF THE RINGS";
                Console.WriteLine("The entire name of the movie is " + sMovieName);
                Console.WriteLine("The lower case name of the movie is " + sMovieName.ToLower());

                //Length
                sMovieName = "lord of the rings";
                Console.WriteLine("The entire name of the movie is " + sMovieName);
                Console.WriteLine("The length of the name of the movie is " + sMovieName.Length);

                //Replace
                sMovieName = "lord of the rings";
                Console.WriteLine("The entire name of the movie is " + sMovieName);
                sMovieName = sMovieName.Replace("l", "L");
                sMovieName = sMovieName.Replace("rings", "Rings");

                Console.WriteLine("The replaced name of the movie is " + sMovieName);
            }
            else
            {
                Console.WriteLine("Skipping String Manipulation #1 per Configuration");
            }

            //Next Section
            //Next Section
            //Next Section
            //Next Section
            //Next Section


        }
    }
}
