using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgrammingMovie.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Kategori Adı")]
        public string Name { get; set; }

        public ICollection<Movie> movies { get; set; }
    }
}
