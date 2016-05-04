using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_MVC6.ViewModels
{
    public class StopViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(255, ErrorMessage = "Tip name must be between 5 and 255 characters", MinimumLength = 5)]
        public string Name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        [Required(ErrorMessage = "Arrival date is required")]
        public DateTime Arrival { get; set; }
    }
}