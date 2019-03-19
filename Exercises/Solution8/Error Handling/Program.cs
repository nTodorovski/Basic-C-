using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 5, 2.5);
                Movie movie2 = new Movie("American Pie", Genre.Comedy, 4, 2.7);
                Movie movie3 = new Movie("Saw", Genre.Horror, 4, 3.5);
                Movie movie4 = new Movie("The Shining", Genre.Horror, 4, 2.4);
                Movie movie5 = new Movie("Rambo", Genre.Action, 4, 8.4);
                Movie movie6 = new Movie("The Terminator", Genre.Action, 4, 3.5);
                Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4, 8.4);
                Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4, 7.7);
                Movie movie9 = new Movie("Passengers", Genre.SciFi, 4, 2.5);
                Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4, 9.5);
                Movie movie11 = new Movie("Airplane", Genre.Comedy, 4, 4.1);
                Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4, 3.2);
                Movie movie13 = new Movie("The Ring", Genre.Horror, 4, 1.9);
                Movie movie14 = new Movie("Sinister", Genre.Horror, 4, 5.6);
                Movie movie15 = new Movie("RoboCop", Genre.Action, 4, 5.1);
                Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4, 6.3);
                Movie movie17 = new Movie("The Social Network", Genre.Drama, 4, 7.3);
                Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4, 9.8);
                Movie movie19 = new Movie("Inception", Genre.SciFi, 4, 8.4);
                Movie movie20 = new Movie("Avatar", Genre.SciFi, 4, 6.5);


                List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };

                List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };

                Cinema cinema1 = new Cinema("Cineplex");
                cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
                cinema1.ListOfMovies = MovieSet1;
                Cinema cinema2 = new Cinema("Milenium");
                cinema2.Halls = new List<int>() { 1, 2 };
                cinema2.ListOfMovies = MovieSet2;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error was: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
