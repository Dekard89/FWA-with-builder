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
        public InputName inputName { get; set; }
        public Recipe recipe { get; set; }
        public List<Recipe> Recipes { get; set; }

        public ViewingModel(IRecipeService recipeService)
        {
            _recipeService = recipeService;

        }

        public void OnGet()
        {
            Recipes = _recipeService.GetActive();
        }
        public void OnPost()
        {

            _recipeService.UpdateActive(recipe);
        }

        public record InputName(string name);

    }
}
