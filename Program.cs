using System;

namespace Fundamentals_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Fundamentals Part 3!");

            //My Config
            bool bTryParse = false;
            bool bConstants = false;
            bool bStringManuplation1 = false;
            bool bStringManuplation2 = false;
            bool bStringExercise = false;
            bool bEscapeSequences = false;
            bool bStringInterpolation = true;

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

            //String Manipulation 2 Section
            if (bStringManuplation2 == true)
            {
                Console.WriteLine("String Manipulation 2!");

                string sTvShow = "Game of Thrones";

                //Index of
                Console.WriteLine("The entire name of the tv show is " + sTvShow);
                Console.WriteLine("The index of o is " + sTvShow.IndexOf("o"));

                //Last Index of
                Console.WriteLine("The last index of o is " + sTvShow.LastIndexOf("o"));

                //Substring
                Console.WriteLine("The substring of index 8 with a length of 7 is " + sTvShow.Substring(8,7));

                //Remove
                Console.WriteLine("The removal of index 8 with a length of 7 is " + sTvShow.Remove(8,7));

                //Insert
                Console.WriteLine("The insert of is awesome " + sTvShow.Insert(15," is awesome!"));

            }
            else
            {
                Console.WriteLine("Skipping String Manipulation #2 per Configuration");
            }

            //String Exercies
            if (bStringExercise == true)
            {
                Console.WriteLine("String Exercises!");

                string sTvShow = "Game of Thrones     ";
                string sSeasonOne = " - Season 1";
                string sNewName = "";

                //Insert
                sNewName = sTvShow.Insert(sTvShow.Trim() .Length,sSeasonOne);
                Console.WriteLine("The edited name is " + sNewName);

            }
            else
            {
                Console.WriteLine("Skipping String Exercises per Configuration");
            }

            //Escape Sequences Section
            if (bEscapeSequences == true)
            {
                Console.WriteLine("Escape Sequences!");

                //Displays Double Quotes
                Console.WriteLine("And Jon Said \"Bend a Knee\"!");
                //Displays Back Slash
                Console.WriteLine("The file is in D:\\Movies\\");
                //Displays Tab
                Console.WriteLine("\t\t 2x TABS");
                //Displays New Line
                Console.WriteLine("A\nNew\nLine");
                //Makes an alarm sound
                Console.WriteLine("Alarm! \a");
            }
            else
            {
                Console.WriteLine("Skipping Escape Sequences per Configuration");
            }

            //String Interpolation Section
            if (bStringInterpolation == true)
            {
                Console.WriteLine("What is your name?");
                string name = "";
                name = Console.ReadLine();

                Console.WriteLine("Nice to see you, " + name); //Variable
                Console.WriteLine("Nice to see you again, {0}" , name); //Place Holder
                Console.WriteLine($"Nice to see you once again, {name}"); //String Interpolation
            }
            else
            {
                Console.WriteLine("Skipping String Interpolation per Configuration");
            }

            //Next Section


        }
    }
}
