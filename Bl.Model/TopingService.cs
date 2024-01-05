using Domain;
using RecipeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Model
{
    public class TopingService:IIngredientService<Toping>
    {
        private readonly IRepository<Recipe> recipeRepository;

        public  Recipe recipe { get; set; }=new Recipe();

        public TopingService(IRepository<Recipe> recipeRepoModel, Recipe recipe)
        {
            recipeRepository = recipeRepoModel;

            this.recipe = recipe;
        }

        public async Task CreateAndAdd(string name, double price, int quantity)
        {
            
            recipe.Topings.Add(Create(name,price,quantity));
            await recipeRepository.Update(recipe);
            
        }

        public Toping FindByName(string name)
        {
            return recipe.Topings.FirstOrDefault(x => x.Name == name);
        }

        public async Task UpdatePrice(Toping toping, double price)
        {
            toping.Price = price;
            await recipeRepository.Update(recipe);
        }

        public async Task UpdateQuantity(Toping toping, int quantity)
        {
            toping.Quantiyy = quantity;
            await recipeRepository.Update(recipe);
        }
        public async Task Add(Toping toping)
        {
            recipe.Topings.Add(toping);
            await recipeRepository.Update(recipe);

        }
        public async Task Delete(Toping toping)
        {
            recipe.Topings.Remove(toping);
            await recipeRepository.Update(recipe);
        }

        public Toping Create(string name, double price, int quantity)
        {
            return new Toping { Name=name,Price=price,Quantiyy=quantity };
        }

       
    }
}
