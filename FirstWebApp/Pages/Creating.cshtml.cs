using Bl.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp.Pages
{
    public class RecipePagesModel : PageModel
    {
        public IRecipeService RecipeRepo { get; set; }

        
        public void OnGet()
        {
        }
        [HttpPost]
        public void OnPost(string name, string img)
        {
            RecipeRepo.Create(name, img);
        }
        
    }

}
