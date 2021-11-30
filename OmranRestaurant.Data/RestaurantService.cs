using OmranRestaurant.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OmranRestaurant.Data
{
    public class RestaurantService : IRestaurantService
    {
        List<Restaurant> Restaurants = new List<Restaurant>()
            {
                new Restaurant { Id=0, Name="Heart attack", Mobile="0123456789", Cuisine=Restaurant.CuisineType.Egyptian, Location="Seqala" },
                new Restaurant { Id=1, Name="MacDonalds", Mobile="0123456789", Cuisine=Restaurant.CuisineType.Mexican, Location="Dahar" },
                new Restaurant { Id=2, Name = "KFC", Mobile="0123456789", Cuisine = Restaurant.CuisineType.Italian, Location = "Sherry" },
            };

        public Restaurant GetRestaurantsById(int id)
        {
            return Restaurants.SingleOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in Restaurants
                   where string.IsNullOrEmpty(name) || r.Name.Contains(name)
                   orderby r.Name
                   select r;
        }

    }
}
