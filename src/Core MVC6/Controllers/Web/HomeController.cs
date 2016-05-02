using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TravelApp.Models;
using Microsoft.Data.Entity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelApp.Controllers
{
    public class HomeController : Controller
    {
        private TripContext db = new TripContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            var Trips = db.Trips.Include(a => a.Stops);
            //ViewBag.test = Trips;
            var TripRepo = new TripsRepository(db);
            //ViewBag.test = TripRepo;
            return View(TripRepo.GetAllTrips());
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}