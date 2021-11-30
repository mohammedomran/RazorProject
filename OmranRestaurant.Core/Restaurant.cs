using System;

namespace OmranRestaurant.Core
{
    public class Restaurant
    {
        public enum CuisineType
        {
            Mexican,
            Italian,
            Egyptian
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Mobile { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
