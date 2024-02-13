using CodeFirst.Models;
using CodeFirst.Models.Context;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        DataContext db;
        public HomeController(DataContext db)
        {
            this.db=db;
        }

        public IActionResult Index()
        {
            //var db = new DataContext();
            var sizes = db.Sizes.ToList();
            return Json(sizes);
        }

    }
}
