using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgrammingMovie.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public string Comment { get; set; }

        public DateTime CommentDate { get; set; } = DateTime.Now;
        public int? MovieId { get; set; }
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        [Range(0, 11)]
        public double Score { get; set; }




    }
}
