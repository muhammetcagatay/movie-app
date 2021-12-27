using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebProgrammingMovie.Enum;

namespace WebProgrammingMovie.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "Ad")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Soyad")]
        public string Surname { get; set; }
        [Display(Name = "Doğum Tarihi")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
        [Display(Name = "Ülke")]
        public CountryEnum Country { get; set; }
        [Display(Name = "Kullanıcı Fotoğrafı")]
        public string PhotoURL { get; set; }

        [NotMapped]
        public string AdSoyad
        {
            get
            {
                return Name + " " + Surname;
            }
        }


    }
}
