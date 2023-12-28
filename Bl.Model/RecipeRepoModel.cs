using Domain;
using RecipeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Model
{
    public class RecipeRepoModel : IRecipeRepoModel
    {
        private readonly IRepository<Recipe> _recipeRepository;

        public RecipeRepoModel(IRepository<Recipe> repository)
        {
            _recipeRepository= repository;
        }

        private List<Recipe> GetActive()
        {
            return _recipeRepository.GetAll().Where(x => x.IsActive==true).ToList();
        }
        public Recipe Create(string name, string image)
        {
            return new Recipe { Name = name, Image=image};
        }

        public Recipe FindByName(string name)
        {
            return GetActive().FirstOrDefault(x => x.Name == name);
        }

        public async Task UpdateName(Recipe recipe, string name)
        {
            recipe.Name = name;
            await _recipeRepository.Update(recipe);
        }

        public async Task UpdateImage(Recipe recipe, string image)
        {
            recipe.Image = image;
            await _recipeRepository.Update(recipe);
        }
    }
}
