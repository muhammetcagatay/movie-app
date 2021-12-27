using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebProgrammingMovie.Data;
using WebProgrammingMovie.Models;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;

namespace WebProgrammingMovie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            int movieCount = _context.Movie.Count();

            var totalmovie = _context.Movie.Include(x => x.Category).Include(x=>x.Rating).Include(x => x.Actor).ToList();
            var slidermovie = _context.Movie.Take(5).Include(x => x.Category).Include(x => x.Rating).Include(x => x.Actor).ToList();
            var trendmovie = _context.Movie.OrderByDescending(x => x.IMDB).Take(5).Include(x => x.Category).Include(x => x.Actor).Include(x => x.Rating).ToList();

            HomeViewModel homeview = new HomeViewModel(totalmovie, trendmovie, slidermovie,"Yeni Çıkanlar");
            return View(homeview);
        }

        public IActionResult GetCategory(int? Id)
        {
            var totalmovie = _context.Movie.Where(x =>x.CategoryId==Id).Include(x => x.Category).Include(x => x.Actor).Include(x => x.Rating).ToList();
            var slidermovie = _context.Movie.Take(5).Include(x => x.Category).Include(x => x.Actor).Include(x => x.Rating).ToList();
            var trendmovie = _context.Movie.OrderByDescending(x => x.IMDB).Take(5).Include(x => x.Actor).Include(x => x.Category).Include(x => x.Rating).ToList();
            var category = _context.Category.Where(x => x.Id ==Id).ToList();
            var category_name = category.ElementAt(0).Name;
            HomeViewModel homeview = new HomeViewModel(totalmovie, trendmovie, slidermovie,category_name);
            return View("Index",homeview);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
    }
}
