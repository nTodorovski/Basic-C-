using Classess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAndCinema
{
    class Program
    {
        static void Main(string[] args)
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

            Cinema cinema1 = new Cinema("Cineplexx");
            cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
            cinema1.ListOfMovies = MovieSet1;
            Cinema cinema2 = new Cinema("Milenium");
            cinema2.Halls = new List<int>() { 1, 2 };
            cinema2.ListOfMovies = MovieSet2;

            try
            {
                Console.WriteLine("Choose Cinema:");
                Console.WriteLine("1. Cineplexx \n2. Milenium");
                int cinemaInput = int.Parse(Console.ReadLine());
                Cinema currentCinema = new Cinema();
                if(cinemaInput == 1)
                {
                    currentCinema = cinema1;
                }else if(cinemaInput == 2)
                {
                    currentCinema = cinema2;
                }
                else
                {
                    throw new Exception("Please enter 1 or 2.");
                }

                Console.WriteLine("Movies in this cinema:");
                Console.WriteLine("1) Show all movies");
                Console.WriteLine("2) Show by genre");
                int moviesInput = int.Parse(Console.ReadLine());
                if(moviesInput == 1)
                {
                    Console.WriteLine("Choose a movie to watch: ( Write the name )");
                    foreach (var movie in currentCinema.ListOfMovies)
                    {
                        Console.WriteLine(movie.Title);
                    }

                    string inputMovie = Console.ReadLine();
                    foreach (Movie movie in currentCinema.ListOfMovies)
                    {
                        if(movie.Title.ToLower() == inputMovie.ToLower())
                        {
                            currentCinema.MoviePlaying(movie);
                        }
                    }
                }else if(moviesInput == 2)
                {
                    Console.WriteLine("Enter genre:");
                    Console.WriteLine("1) Comedy");
                    Console.WriteLine("2) Horror");
                    Console.WriteLine("3) Action");
                    Console.WriteLine("4) Drama");
                    Console.WriteLine("5) SciFi");
                    int inputGenre = int.Parse(Console.ReadLine());
                    Genre currentGenre = new Genre();

                    switch (inputGenre)
                    {
                        case 1:
                            currentGenre = Genre.Comedy;
                            break;
                        case 2:
                            currentGenre = Genre.Horror;
                            break;
                        case 3:
                            currentGenre = Genre.Action;
                            break;
                        case 4:
                            currentGenre = Genre.Drama;
                            break;
                        case 5:
                            currentGenre = Genre.SciFi;
                            break;
                        default:
                            throw new Exception("The genre input was not correct!");
                    }

                    Console.WriteLine("Choose a movie to watch: ( Write the name )");
                    List<Movie> personMovies = new List<Movie>();
                    foreach (var movie in currentCinema.ListOfMovies.Where(movie => movie.Genre == currentGenre).ToList())
                    {
                        personMovies.Add(movie);
                        Console.WriteLine(movie.Title);
                    }

                    string inputFilm = Console.ReadLine();
                    currentCinema.MoviePlaying(personMovies.Where(movie => movie.Title.Trim().ToLower() == inputFilm.Trim().ToLower()).FirstOrDefault());
                }
                else
                {
                    throw new Exception("You have entered a wrong input!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You did not enter a correct format!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("There is no movie like that!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
