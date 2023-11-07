using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskPlanner.Models;
using TaskPlanner.Models.Interfaces;
using TaskPlanner.ViewModels;

namespace TaskPlanner.Controllers
{
    public class HomeController : Controller
    {
        private IStorage storage;

        public HomeController(IStorage storage)
        {
            this.storage = storage;
        }

        public ActionResult Index()
        {
            return this.View(new CalendarViewModelBuilder(this.storage).Build());
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