using Microsoft.AspNetCore.Mvc;
using MyFirstProjectWeb.Data;
using MyFirstProjectWeb.Models;

namespace MyFirstProjectWeb.Controllers
{
    public class CategoryController : Controller
    {
        readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        //get
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        //get
        public IActionResult Create()
        {
            return View();
        }

        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            return View();
        }
    }
}
