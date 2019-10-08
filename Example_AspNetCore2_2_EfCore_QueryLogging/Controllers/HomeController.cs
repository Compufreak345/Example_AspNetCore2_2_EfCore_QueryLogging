using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Example_AspNetCore2_2_EfCore_QueryLogging.Models;
using Example_AspNetCore2_2_EfCore_QueryLogging.Data;

namespace Example_AspNetCore2_2_EfCore_QueryLogging.Controllers
{
    public class HomeController : Controller
    {
        public SampleDbContext dbContext { get; }

        public HomeController(SampleDbContext dbContext)
        {

            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var users = this.dbContext.Users.Select(c=>c).ToList();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
