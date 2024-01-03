using Bl.Model;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;

namespace FirstWebApp.Pages
{
    public class RecipePagesModel : PageModel
    {
        private readonly IRecipeService _recipeService;

        public Recipe createdRecipe { get; set; }=new Recipe();

        public RecipePagesModel(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }


        [BindProperty]
        public InputRecipe inputRecipe { get; set; }

        
        public void OnGet()
        {
        }
       
        public void OnPost()
        {
            createdRecipe= _recipeService.Create(inputRecipe.name,inputRecipe.img);

        }

        public record InputRecipe(string name, string img);
        
    }

}
