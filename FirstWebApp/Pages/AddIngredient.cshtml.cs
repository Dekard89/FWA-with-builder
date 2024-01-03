using Bl.Model;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp.Pages
{
    public class AddIngredientModel : PageModel
    { 
        public Recipe recipe { get; set; }

        public Ingredient Ingredient { get; set; }
        
        private readonly IRecipeService _recipeService;

        private readonly IngredientServiceTroughtRecipe ingredientService;

        public int Counter { get; set; } = 1;
    
        public IActionResult OnGet(string rName)
        {
            recipe = _recipeService.FindByName(rName);
            if (recipe == null)
             return RedirectToPage("/Error");

            return Page();
        }
    }
}
