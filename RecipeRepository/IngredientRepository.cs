using DbRecipeContext;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeRepository
{
    public class IngredientRepository : IRepository<Ingredient>
    {
        private readonly RecipeContext _recipeContext;

        public IngredientRepository(RecipeContext recipeContext)
        {
                _recipeContext = recipeContext;
        }
        public async Task Add(Ingredient item)
        {
            await _recipeContext.Ingredients.AddAsync(item);
            await _recipeContext.SaveChangesAsync();
        }

        public async Task Delete(Ingredient item)
        {
            _recipeContext.Ingredients.Remove(item);
            await _recipeContext.SaveChangesAsync();
        }

        public List<Ingredient> GetAll()
        {
            return _recipeContext.Ingredients.Include(r=>r.Recipes).ToList();
        }

        public async Task Update(Ingredient item)
        {
            _recipeContext.Ingredients.Update(item);
            await _recipeContext.SaveChangesAsync();
        }
    }
}
