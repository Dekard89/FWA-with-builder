using Bl.Model;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp.Pages
{
    public class AddIngredientModel : PageModel
    {
        [BindProperty]
        public InputIngredient inputIngredient { get; set; }
        public Recipe recipe { get; set; }

        public Ingredient Ingredient { get; set; }
        
        private readonly IRecipeService _recipeService;

        private readonly IngredientServiceTroughtRecipe _ingredientService;

        public AddIngredientModel(IngredientServiceTroughtRecipe ingredientService, IRecipeService recipeService)
        {
            _ingredientService = ingredientService;
            _recipeService = recipeService;
        }

        public int Counter { get; set; } = 1;
    
        public IActionResult OnGet(string rName)
        {
            recipe = _recipeService.FindByName(rName);

            _ingredientService.recipe = recipe;
            if (recipe == null)
             return RedirectToPage("/Error");

            return Page();
        }
        public IActionResult OnPost()
        {
            Counter++;
            _ingredientService.CreateAndAdd(inputIngredient.name, Convert.ToDouble(inputIngredient.price), 1);
            
            return this.Page();
        }
        public record InputIngredient(string name, string price);
    }
}
