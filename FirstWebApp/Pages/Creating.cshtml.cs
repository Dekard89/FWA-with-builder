using Bl.Model;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp.Pages
{
    public class RecipePagesModel : PageModel
    {
        private readonly IRecipeService _recipeService;

        public Recipe createdRecipe { get; set; } = new Recipe();

        public RecipePagesModel(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }


        [BindProperty]
        public InputRecipe inputRecipe { get; set; }


        public IActionResult OnGet()
        {
            return Page();
        }

        public void OnPost()
        {
            createdRecipe = _recipeService.Create(inputRecipe.name, inputRecipe.img);

        }

        public class InputRecipe
        {
            public string name { get; set; } = "";

            public string img
            {
                get => img;

                set => img = GetFilePath();
            }



            public IFormFile File { get; set; }

            private readonly IWebHostEnvironment _webHostEnvironment;

            public InputRecipe(IWebHostEnvironment webHost)
            {
                _webHostEnvironment = webHost;
            }
            private string GetFilePath()
            {
                string uniqueFileName = null;

                if (File != null)
                {
                    string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");

                    uniqueFileName = Guid.NewGuid().ToString() + "_" + File.FileName;

                    string filePath = Path.Combine(uploadFolder, uniqueFileName);

                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        File.CopyTo(fs);
                    }
                }
                return uniqueFileName;
            }
        }

    }
}