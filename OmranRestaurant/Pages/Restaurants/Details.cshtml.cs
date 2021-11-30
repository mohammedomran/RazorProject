using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OmranRestaurant.Core;
using OmranRestaurant.Data;

namespace OmranRestaurant.Pages.Restaurants
{
    public class DetailsModel : PageModel
    {
        private readonly IRestaurantService service;
        public DetailsModel(IRestaurantService service)
        {
            this.service = service;
        }
        public Restaurant Restaurant { get; set; }
        public void OnGet(int id)
        {
            Restaurant = service.GetRestaurantsById(id);
        }
    }
}
