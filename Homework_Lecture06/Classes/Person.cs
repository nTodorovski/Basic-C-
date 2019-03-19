using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(string firstName,string lastName,int age,Genre favoriteMusic)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusic;
        }

        public void GetFavSongs()
        {
            if (FavoriteSongs.Count == 0)
            {
                Console.WriteLine("The person hates music.");
                return;
            }
            else
            {
                foreach (var song in FavoriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
                return;
            }
        }
    }
}
