using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgrammingMovie.Models
{
    public class HomeViewModel
    {
        public List<Movie> _TotalMovie { get; set; }
        public List<Movie> _TrendMovie { get; set; }
        public List<Movie> _SliderMovie { get; set; }
        //categoriye özelse true tüm kategoriler gelirse false
        public string _categoryName { get; set; }

        public HomeViewModel(List<Movie> TotalMovie, List<Movie> TrendMovie, List<Movie> SliderMovie,string categoryName)
        {
            _TotalMovie = TotalMovie;
            _TrendMovie = TrendMovie;
            _SliderMovie = SliderMovie;
            _categoryName = categoryName;
        }
    }
}
