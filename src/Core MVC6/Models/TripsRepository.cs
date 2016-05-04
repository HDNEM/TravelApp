using Core_MVC6.Models;
using Microsoft.Data.Entity;
using System.Collections.Generic;
using System.Linq;


namespace TravelApp.Models
{
    public class TripsRepository
    {
        private TripContext db;

        public TripsRepository(TripContext context)
        {
            db = context;
        }

        public IEnumerable<Trip> GetAllTrips()
        {
            var trips = db.Trips.Include(a => a.Stops);
            return trips;
        }

        public Trip GetTrip(int id)
        {
            var trip = db.Trips.Include(a => a.Stops).Where(a => a.ID == id).Single();
            return trip;
        }

        public Trip Post(Trip trip)
        {
            db.Trips.Add(trip);
            db.SaveChanges();
            return trip;
        }
    }
}