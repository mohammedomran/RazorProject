using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OmranRestaurant.Core;
using OmranRestaurant.Data;

namespace OmranRestaurant.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        private readonly IRestaurantService service;
        private readonly IHtmlHelper htmlHelper;
        public EditModel(IRestaurantService service, IHtmlHelper htmlHelper)
        {
            this.service = service;
            this.htmlHelper = htmlHelper;
        }

        [BindProperty]
        public Restaurant Restaurant { get; set; }
        public IEnumerable<SelectListItem> Cuisines { get; set; }
        public IActionResult OnGet(int? id)
        {
            Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
            if (id.HasValue)
            {
                Restaurant = service.GetRestaurantsById((int)id);
            }
            else
            {
                Restaurant = new Restaurant();
            }   
            
            return Restaurant == null ? RedirectToPage("./NotFound") : Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
                return Page();
            }
            if (Restaurant.Id > 0)
            {
                service.Update(Restaurant);
            }
            else
            {
                service.Add(Restaurant);
            }
            return RedirectToPage("./Details", new { id = Restaurant.Id });
        }
    }
}
