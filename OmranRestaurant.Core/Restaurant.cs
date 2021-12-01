using System;
using System.ComponentModel.DataAnnotations;

namespace OmranRestaurant.Core
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(200)]
        public string Location { get; set; }
        [Required, MaxLength(15)]
        public string Mobile { get; set; }
        [Required]
        public CuisineType Cuisine { get; set; }
    }
}
