using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classess
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public double Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie(string title, Genre genre, double rating, double ticketPrice = 5)
        {
            if (rating < 1 || rating > 5)
            {
                throw new Exception("Not a number from 1 to 5");
            }
            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = ticketPrice * Rating;
        }
    }
}
