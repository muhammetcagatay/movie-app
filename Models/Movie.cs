using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebProgrammingMovie.Enum;

namespace WebProgrammingMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Film Adı")]
        public string Name { get; set; }
        [Display(Name = "Özet")]
        public string Review { get; set; }
        [Display(Name = "İzlenme Sayısı")]
        public int View { get; set; }


        [Display(Name = "Kategori Adı")]
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }


        [Display(Name = "Yapımcı Adı")]
        public int? DirectorId { get; set; }
        [ForeignKey("DirectorId")]
        public Director Director { get; set; }


        [Display(Name = "Slider Fotoğraf Adresi")]
        public string SliderPhotoURL { get; set; }

        [Display(Name = "Detay Fotoğraf Adresi")]
        public string DetailPhotoURL { get; set; }


        internal static string FirstOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
        [Display(Name = "Çıkış Tarihi")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Film Süresi")]
        public double Duration { get; set; }
        public double IMDB { get; set; }
        [Display(Name = "Ülke")]
        public CountryEnum Country { get; set; }

        public ICollection<Actor> Actor { get; set; }
        public ICollection<Rating> Rating { get; set; }

    }

}
