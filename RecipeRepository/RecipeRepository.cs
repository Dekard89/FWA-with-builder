using DbRecipeContext;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeRepository
{
    public class RecipeRepository : IRepository<Recipe>
    {
        private readonly RecipeContext _recipeContext;

        public RecipeRepository(RecipeContext recipeContext)
        {
               _recipeContext = recipeContext;
        }
        public async Task Add(Recipe item)
        {
            await _recipeContext.Recipes.AddAsync(item);
            await _recipeContext.SaveChangesAsync();
        }

        public async Task Delete(Recipe item)
        {
             _recipeContext.Recipes.Remove(item);
            await _recipeContext.SaveChangesAsync();
        }

        public Task<<Recipe>> GetAll()
        {
            return _recipeContext.Recipes.ToList();
        }

        public Task Update(Recipe item)
        {
            throw new NotImplementedException();
        }
    }
}
