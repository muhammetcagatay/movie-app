using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgrammingMovie.Models
{
    public class Director
    {
        public int Id { get; set; }

        [Display(Name = "Yapımcı Adı")]
        public string DirectorName { get; set; }

        public ICollection<Movie> movies { get; set; }


    }
}
