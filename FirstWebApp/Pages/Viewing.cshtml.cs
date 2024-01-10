using Bl.Model;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp.Pages
{
    public class ViewingModel : PageModel
    {
        private readonly IRecipeService _recipeService;

        [BindProperty]
        public List<Recipe> Recipes { get; set; }

        public ViewingModel(RecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public void OnGet()
        {
            Recipes = _recipeService.GetActive();
        }
    }
}
