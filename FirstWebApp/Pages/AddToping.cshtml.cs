using Bl.Model;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp.Pages
{
    public class AddTopingModel : PageModel
    {
        [BindProperty]
        public InputTopuing inputTopuing { get; set; }

        private readonly TopingService _topingService;

        private readonly IRecipeService _recipeService;

        public AddTopingModel(TopingService topingService,IRecipeService recipeService)
        {
            _recipeService = recipeService;
            _topingService = topingService;
        }
        public int Counter { get; set; } = 1;

        public Recipe recipe { get; set; }
        public IActionResult OnGet(string rName)
        {
            recipe=_recipeService.FindByName(rName);
            if (recipe == null)
                return RedirectToPage("/Error");
            _topingService.recipe=recipe;

            return Page();
        }
        public IActionResult OnPost()
        {

        }
        
    }
    public record InputTopuing(string name, string price);
}
