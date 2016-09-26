using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello World";


            string year = "1492.";


            bool dog = false;


            DateTime today = DateTime.UtcNow;


            string money = "$5.45";

            string letter = "X";

            string sail = "Columbus sailed the world in";

            string dog1 = "It is";

            string dog2 = "that I have a dog at home.";

            string date = "Today is";

            string spent = "I spent";

            string cheeseburger = "on a cheeseburger.";

            string finish = "marks the spot";



            Console.WriteLine(myString);

            Console.WriteLine(sail + " " + year);

            Console.WriteLine(dog1 + " " + dog.ToString().ToLower() + " " + dog2);

            Console.WriteLine(date + " " + today);

            Console.WriteLine(spent + " " + money + " " + cheeseburger);

            Console.WriteLine(letter + " " + finish);
            Console.WriteLine();





            string[] favoriteMovieArray = new string[] { "Pretty Woman", "Coming To America", "Blow", "Friday" };


            Console.WriteLine(favoriteMovieArray[0]);
            Console.WriteLine(favoriteMovieArray[1]);
            Console.WriteLine(favoriteMovieArray[2]);
            Console.WriteLine(favoriteMovieArray[3]);
            Console.WriteLine();


            var person = new { firstName = "Jasmine", lastName = "Perry", age = "?", mood = "elated" };


            Console.WriteLine(person);

            Console.WriteLine();





            



            dynamic movies = new[]
            {
                new { title = "Pretty Woman", releaseDate = "1990", rating = "R" },
                new { title = "Coming To America", releaseDate = "1988", rating = "R"},
                new { title = "Blow", releaseDate = "2001", rating = "R"},
                new { title = "Friday", releaseDate = "1995", rating = "R"},

            };

            for (int m = 0; m < movies.Length; m++)
            {
                Console.WriteLine(movies[m]);
            }

            Console.ReadLine();
            
        }







    }

}
