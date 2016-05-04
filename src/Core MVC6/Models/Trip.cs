using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core_MVC6.Models
{
    public class Trip
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public String Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public String UserName { get; set; }
        public ICollection<Stop> Stops { get; set; }
    }
}
