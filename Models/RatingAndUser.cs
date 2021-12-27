using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgrammingMovie.Models
{
    public class RatingAndUser
    {
        public RatingAndUser(Rating _rating, ApplicationUser _user)
        {
            rating = _rating;
            user = _user;
             
        }
        public Rating rating { get; set; }
        public ApplicationUser user { get; set; }
    }
}
