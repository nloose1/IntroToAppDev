using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class EMovies
    {
        public string MovieTitle { get; set; }
        public string Year { get; set; }
        public string Media { get; set; }
        public string Rating { get; set; }
        public string Review { get; set; }
        public string ISBN { get; set; }

        public EMovies()
        {

        }

        public EMovies(string movietitle, string year, string media, string rating, string review, string isbn)
        {
            MovieTitle = movietitle;
            Year = year;
            Media = media;
            Rating = rating;
            Review = review;
            ISBN = isbn;
        }
    }
}