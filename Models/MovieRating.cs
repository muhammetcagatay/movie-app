using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgrammingMovie.Models
{
    public class MovieRating
    {
        public MovieRating(Movie _movie, List<RatingAndUser> _ratinganduser,double _RatingAvarage)
        {
            movie = _movie;
            ratinganduser = _ratinganduser;
            RatingAvarage = _RatingAvarage;

        }
        public Movie movie { get; set; }
        public List<RatingAndUser> ratinganduser { get; set; }
        public double RatingAvarage { get; set; }
    }
}
