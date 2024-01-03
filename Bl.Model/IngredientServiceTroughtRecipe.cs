using Domain;
using RecipeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Model
{
    public class IngredientRepoModelTroughtRecipe : IIngredintModel<Ingredient>
    {
        private readonly IRepository<Recipe> recipeRepository;

        private readonly Recipe _recipe;

        public IngredientRepoModelTroughtRecipe(IRepository<Recipe> repository,Recipe recipe) 
        {
             recipeRepository= repository;
            _recipe = recipe;
        }
        public Ingredient Create(string name, double price, int quantity)
        {
            return new Ingredient { Name= name, Price = price, Quantity = quantity };
        }   

        public async Task CreateAndAdd(string name, double price, int quantity)
        {
            _recipe.Ingredients.Add(Create(name, price, quantity));
            await recipeRepository.Update(_recipe);
        }

        public Ingredient FindByName(string name)
        {
            return _recipe.Ingredients.FirstOrDefault(x => x.Name == name);
        }

        public async Task UpdatePrice(Ingredient entity, double price)
        {
            entity.Price = price;
            await recipeRepository.Update(_recipe);
        }

        public async Task UpdateQuantity(Ingredient entity, int quantity)
        {
            entity.Quantity = quantity;
            await recipeRepository.Update(_recipe);
        }
    }
}
