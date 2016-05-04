using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Core_MVC6.Models;
using Microsoft.Data.Entity;
using AutoMapper;
using TravelApp.Services;
using TravelApp.Models;
using Core_MVC6.ViewModels;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Core_MVC6.Controllers.API
{
    [Route("api/[controller/{tripName}]")]
    public class StopsController : Controller
    {
        private TripContext db;
        private CoordinateService cs;

        public StopsController(TripContext tc, CoordinateService c)
        {
            db = tc;
            cs = c;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(string tripName)
        {
            var stops = db.Trips.Include(a => a.Stops).Where(a => a.Name == tripName);
            var result = Mapper.Map<IEnumerable<StopViewModel>>(stops);
            return Json(result);
        }

        // POST api/values
        [HttpPost]
        public async Task <JsonResult> Post(TripViewModel trip, StopViewModel stop)
        {
            var aTrip = Mapper.Map<Trip>(trip);
            var aStop = Mapper.Map<Stop>(stop);

            var coord = await cs.Lookup(aStop.Name);
            if (coord.Success)
            {
                aStop.Longitude = coord.Longitude;
                aStop.Latitude = coord.Latitude;
            }

            aTrip.Stops.Add(aStop);
            if(ModelState.IsValid)
            {
                db.Trips.Update(aTrip);
                db.SaveChanges();
            }

            var result = Mapper.Map<TripViewModel>(aTrip);
            return Json(result);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
