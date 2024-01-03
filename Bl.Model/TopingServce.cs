using Domain;
using RecipeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Model
{
    public class TopingServce:IIngredientService<Toping>
    {
        private readonly IRepository<Recipe> recipeRepository;

        private readonly Recipe _recipe;

        public TopingServce(IRepository<Recipe> recipeRepoModel, Recipe recipe)
        {
            recipeRepository = recipeRepoModel;

            _recipe = recipe;
        }

        public async Task CreateAndAdd(string name, double price, int quantity)
        {
            
            _recipe.Topings.Add(Create(name,price,quantity));
            await recipeRepository.Update(_recipe);
            
        }

        public Toping FindByName(string name)
        {
            return _recipe.Topings.FirstOrDefault(x => x.Name == name);
        }

        public async Task UpdatePrice(Toping toping, double price)
        {
            toping.Price = price;
            await recipeRepository.Update(_recipe);
        }

        public async Task UpdateQuantity(Toping toping, int quantity)
        {
            toping.Quantiyy = quantity;
            await recipeRepository.Update(_recipe);
        }
        public async Task Add(Toping toping)
        {
            _recipe.Topings.Add(toping);
            await recipeRepository.Update(_recipe);

        }
        public async Task Delete(Toping toping)
        {
            _recipe.Topings.Remove(toping);
            await recipeRepository.Update(_recipe);
        }

        public Toping Create(string name, double price, int quantity)
        {
            return new Toping { Name=name,Price=price,Quantiyy=quantity };
        }

       
    }
}
