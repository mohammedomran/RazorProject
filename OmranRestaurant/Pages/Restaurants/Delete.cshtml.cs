using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OmranRestaurant.Core;
using OmranRestaurant.Data;

namespace OmranRestaurant.Pages.Restaurants
{
    public class DeleteModel : PageModel
    {
        private readonly IRestaurantService service;
        public DeleteModel(IRestaurantService service)
        {
            this.service = service;
        }

        public Restaurant Restaurant { get; set; }
        public IActionResult OnGet(int id)
        {
            Restaurant = service.GetRestaurantsById((int)id);
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            bool IsDeleted = service.Delete(id);
            if (IsDeleted)
            {
                return RedirectToPage("./List");
            }
            return RedirectToPage("./NotFound");
        }
    }
}
