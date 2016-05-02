using Core_MVC6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelApp.Models;

namespace TravelApp.Models
{
    public class TripsSeedData
    {
        private TripContext db;

        public TripsSeedData(TripContext context)
        {
            db = context;
        }

        public void InsertSeedData()
        {
            // If database does not contain any data, add some
            if (!db.Trips.Any())
            {
                var aTrip = new Trip()
                {
                    Name = "Coast to Coast",
                    CreatedDate = DateTime.Now,
                    UserName = "",
                    Stops = new List<Stop>()
                    {
                        new Stop() {  Name = "Philadelphia, PA", ArrivalDate = new DateTime(2015, 10, 20), Latitude = 39.94907, Longitude = -75.16059, Order = 0 },
                        new Stop() {  Name = "New York, NY", ArrivalDate = new DateTime(2015, 10, 23), Latitude = 40.712784, Longitude = -74.005941, Order = 1 },
                        new Stop() {  Name = "Chicago, IL", ArrivalDate = new DateTime(2015, 10, 30), Latitude = 41.878114, Longitude = -87.629798, Order = 2 },
                        new Stop() {  Name = "Seattle, WA", ArrivalDate = new DateTime(2015, 11, 1), Latitude = 47.606209, Longitude = -122.332071, Order = 3 },
                        new Stop() {  Name = "Philadelphia, PA", ArrivalDate = new DateTime(2015, 11, 20), Latitude = 39.94907, Longitude = -75.16059, Order = 4 }

                    }
                };
                db.Trips.Add(aTrip);
                db.Stops.AddRange(aTrip.Stops);

                var bigTrip = new Trip()
                {
                    Name = "Around the World",
                    CreatedDate = DateTime.Now,
                    UserName = "",
                    Stops = new List<Stop>()
                    {
                        new Stop() { Order = 0, Latitude = 39.94907, Longitude = -75.16059, Name = "Philadelphia, PA", ArrivalDate = DateTime.Parse("June 1, 2014") },
                        new Stop() { Order = 1, Latitude =  48.856614, Longitude =  2.352222, Name = "Paris, France",ArrivalDate = DateTime.Parse("Jun 4, 2014") },
                        new Stop() { Order = 2, Latitude =  50.850000, Longitude =  4.350000, Name = "Brussels, Belgium",ArrivalDate = DateTime.Parse("Jun 25, 2014") },
                        new Stop() { Order = 3, Latitude =  51.209348, Longitude =  3.224700, Name = "Bruges, Belgium",ArrivalDate = DateTime.Parse("Jun 28, 2014") },
                        new Stop() { Order = 4, Latitude =  48.856614, Longitude =  2.352222, Name = "Paris, France",ArrivalDate = DateTime.Parse("Jun 30, 2014") },
                        new Stop() { Order = 5, Latitude =  51.508515, Longitude =  -0.125487, Name = "London, UK",ArrivalDate = DateTime.Parse("Jul 8, 2014") },
                        new Stop() { Order = 6, Latitude =  51.454513, Longitude =  -2.587910, Name = "Bristol, UK",ArrivalDate = DateTime.Parse("Jul 24, 2014") },
                        new Stop() { Order = 7, Latitude =  52.954783, Longitude =  -1.158109, Name = "Nottingham, UK",ArrivalDate = DateTime.Parse("Jul 31, 2014") },
                        new Stop() { Order = 8, Latitude =  55.953252, Longitude =  -3.188267, Name = "Edinburgh, UK",ArrivalDate = DateTime.Parse("Aug 5, 2014") },
                        new Stop() { Order = 9, Latitude =  55.864237, Longitude =  -4.251806, Name = "Glasgow, UK",ArrivalDate = DateTime.Parse("Aug 6, 2014") },
                        new Stop() { Order = 10, Latitude =  55.953252, Longitude =  -3.188267, Name = "Edinburgh, UK",ArrivalDate = DateTime.Parse("Aug 8, 2014") },
                        new Stop() { Order = 11, Latitude =  51.508515, Longitude =  -0.125487, Name = "London, UK",ArrivalDate = DateTime.Parse("Aug 10, 2014") },
                        new Stop() { Order = 12, Latitude =  52.370216, Longitude =  4.895168, Name = "Amsterdam, Netherlands",ArrivalDate = DateTime.Parse("Aug 14, 2014") },
                        new Stop() { Order = 13, Latitude =  48.583148, Longitude =  7.747882, Name = "Strasbourg, France",ArrivalDate = DateTime.Parse("Aug 17, 2014") },
                        new Stop() { Order = 14, Latitude =  46.519962, Longitude =  6.633597, Name = "Lausanne, Switzerland",ArrivalDate = DateTime.Parse("Aug 19, 2014") },
                        new Stop() { Order = 15, Latitude =  46.021073, Longitude =  7.747937, Name = "Zermatt, Switzerland",ArrivalDate = DateTime.Parse("Aug 27, 2014") },
                        new Stop() { Order = 16, Latitude =  46.519962, Longitude =  6.633597, Name = "Lausanne, Switzerland",ArrivalDate = DateTime.Parse("Aug 29, 2014") },
                        new Stop() { Order = 17, Latitude =  54.597285, Longitude =  -5.930120, Name = "Belfast, Northern Ireland",ArrivalDate = DateTime.Parse("Sep 7, 2014") },
                        new Stop() { Order = 18, Latitude =  53.349805, Longitude =  -6.260310, Name = "Dublin, Ireland",ArrivalDate = DateTime.Parse("Sep 9, 2014") },
                        new Stop() { Order = 19, Latitude =  47.368650, Longitude =  8.539183, Name = "Zurich, Switzerland",ArrivalDate = DateTime.Parse("Sep 16, 2014") },
                        new Stop() { Order = 20, Latitude =  48.135125, Longitude =  11.581981, Name = "Munich, Germany",ArrivalDate = DateTime.Parse("Sep 19, 2014") },
                        new Stop() { Order = 21, Latitude =  51.050409, Longitude =  13.737262, Name = "Dresden, Germany",ArrivalDate = DateTime.Parse("Oct 1, 2014") },
                        new Stop() { Order = 22, Latitude =  50.075538, Longitude =  14.437800, Name = "Prague, Czech Republic",ArrivalDate = DateTime.Parse("Oct 4, 2014") },
                        new Stop() { Order = 23, Latitude =  42.697708, Longitude =  23.321868, Name = "Sofia, Bulgaria",ArrivalDate = DateTime.Parse("Oct 16, 2014") },
                        new Stop() { Order = 24, Latitude =  41.005270, Longitude =  28.976960, Name = "Istanbul, Turkey",ArrivalDate = DateTime.Parse("Nov 1, 2014") },
                        new Stop() { Order = 25, Latitude =  45.815011, Longitude =  15.981919, Name = "Zagreb, Croatia",ArrivalDate = DateTime.Parse("Nov 11, 2014") },
                        new Stop() { Order = 26, Latitude =  41.005270, Longitude =  28.976960, Name = "Istanbul, Turkey",ArrivalDate = DateTime.Parse("Nov 15, 2014") },
                        new Stop() { Order = 27, Latitude =  50.850000, Longitude =  4.350000, Name = "Brussels, Belgium",ArrivalDate = DateTime.Parse("Nov 25, 2014") },
                        new Stop() { Order = 28, Latitude =  50.937531, Longitude =  6.960279, Name = "Cologne, Germany",ArrivalDate = DateTime.Parse("Nov 30, 2014") },
                        new Stop() { Order = 29, Latitude =  48.208174, Longitude =  16.373819, Name = "Vienna, Austria",ArrivalDate = DateTime.Parse("Dec 4, 2014") },
                        new Stop() { Order = 30, Latitude =  47.497912, Longitude =  19.040235, Name = "Budapest, Hungary",ArrivalDate = DateTime.Parse("Dec 28,2014") },
                        new Stop() { Order = 31, Latitude =  37.983716, Longitude =  23.729310, Name = "Athens, Greece",ArrivalDate = DateTime.Parse("Jan 2, 2015") },
                        new Stop() { Order = 32, Latitude =  43.771033, Longitude =  11.248001, Name = "Florence, Italy",ArrivalDate = DateTime.Parse("Feb 1, 2015") },
                        new Stop() { Order = 33, Latitude =  41.872389, Longitude =  12.480180, Name = "Rome, Italy",ArrivalDate = DateTime.Parse("Feb 17, 2015") },
                        new Stop() { Order = 34, Latitude =  28.632244, Longitude =  77.220724, Name = "New Delhi, India",ArrivalDate = DateTime.Parse("Mar 4, 2015") },
                        new Stop() { Order = 35, Latitude =  27.700000, Longitude =  85.333333, Name = "Kathmandu, Nepal",ArrivalDate = DateTime.Parse("Mar 10, 2015") },
                        new Stop() { Order = 36, Latitude =  22.1667, Longitude =  113.5500, Name = "Macau",ArrivalDate = DateTime.Parse("Mar 21, 2015") },
                        new Stop() { Order = 37, Latitude =  22.396428, Longitude =  114.109497, Name = "Hong Kong",ArrivalDate = DateTime.Parse("Mar 24, 2015") },
                        new Stop() { Order = 38, Latitude =  39.904030, Longitude =  116.407526, Name = "Beijing, China",ArrivalDate = DateTime.Parse("Apr 19, 2015") },
                        new Stop() { Order = 39, Latitude =  1.352083, Longitude =  103.819836, Name = "Singapore",ArrivalDate = DateTime.Parse("Apr 30, 2015") },
                        new Stop() { Order = 40, Latitude =  3.139003, Longitude =  101.686855, Name = "Kuala Lumpor, Malaysia",ArrivalDate = DateTime.Parse("May 7, 2015") },
                        new Stop() { Order = 41, Latitude =  13.727896, Longitude =  100.524123, Name = "Bangkok, Thailand",ArrivalDate = DateTime.Parse("May 24, 2015") },
                        new Stop() { Order = 42, Latitude = 39.94907, Longitude = -75.16059, Name = "Philadelphia, PA", ArrivalDate = DateTime.Parse("Jun 1, 2015") },
                    }
                };

                db.Trips.Add(bigTrip);
                db.Stops.AddRange(bigTrip.Stops);
                db.SaveChanges();
            }
        }
    }
}