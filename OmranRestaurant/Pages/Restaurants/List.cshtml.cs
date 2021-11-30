using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OmranRestaurant.Core;
using OmranRestaurant.Data;

namespace OmranRestaurant.Pages.NewFolder
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantService service;
        public IndexModel(IConfiguration config, IRestaurantService service)
        {
            this.config = config;
            this.service = service;
        }
        public string Message { get; set; }
        public string Res { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public void OnGet(string restaurantName)
        {
            Message = config["Message"];
            Restaurants = service.GetRestaurantsByName(restaurantName);
        }
    }
}
