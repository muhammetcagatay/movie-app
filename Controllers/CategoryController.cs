using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgrammingMovie.Data;

namespace WebProgrammingMovie.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: CategoryController
        public ActionResult Index()
        {
            var categories = _context.Category.ToList();
            return View(categories);
        }
    }
}
