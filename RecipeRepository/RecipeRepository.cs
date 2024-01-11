using DbRecipeContext;
using Domain;
using Microsoft.EntityFrameworkCore;

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

        public List<Recipe> GetAll()
        {
            return _recipeContext.Recipes.Include(i => i.Ingredients)
                .Include(t => t.Topings).ToList();
        }

        public async Task Update(Recipe item)
        {
            _recipeContext.Recipes.Update(item);
            await _recipeContext.SaveChangesAsync();
        }
    }
}
