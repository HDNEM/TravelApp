using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_MVC6.Models
{
    public class Trip
    {
        public int ID { get; set; }
        [Required]
        public String Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public String UserName { get; set; }
        public ICollection<Stop> Stops { get; set; }
    }
}
