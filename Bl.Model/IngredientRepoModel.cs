using Domain;
using RecipeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Model
{
    public class IngredientRepoModel : IIngredintModel<Ingredient>
    {

        private readonly IRepository<Ingredient> _repository;

       
        public Ingredient Create(string name, double price, int quantity)
        {
            return new Ingredient { Name= name, Price = price, Quantity = quantity };
        }

        public Ingredient FindByName(string name)
        {
            return _repository.GetAll().FirstOrDefault(x=>x.Name==name);
        }

        public async Task UpdatePrice(Ingredient ingredient, double price)
        {
            ingredient.Price = price;
            await _repository.Update(ingredient);
        }

        public async Task UpdateQuantity(Ingredient ingredient, int quantity)
        {
            ingredient.Quantity = quantity;
            await _repository.Update(ingredient);
        }

        public async Task CreateAndAdd(string name, double price, int quantity)
        {
           await _repository.Add(Create(name, price, quantity));

        }
    }
}
