using Domain;
using RecipeRepository;

namespace Bl.Model
{
    public class IngredientServiceTroughtRecipe : IIngredientService<Ingredient>
    {
        private readonly IRepository<Recipe> recipeRepository;

        public Recipe recipe { get; set; } = new Recipe();

        public IngredientServiceTroughtRecipe(IRepository<Recipe> repository)
        {
            recipeRepository = repository;

        }
        public Ingredient Create(string name, double price, int quantity)
        {
            return new Ingredient { Name = name, Price = price, Quantity = quantity };
        }

        public async Task CreateAndAdd(string name, double price, int quantity)
        {
            recipe.Ingredients.Add(Create(name, price, quantity));
            await recipeRepository.Update(recipe);
        }

        public Ingredient FindByName(string name)
        {
            return recipe.Ingredients.FirstOrDefault(x => x.Name == name);
        }

        public async Task UpdatePrice(Ingredient entity, double price)
        {
            entity.Price = price;
            await recipeRepository.Update(recipe);
        }

        public async Task UpdateQuantity(Ingredient entity, int quantity)
        {
            entity.Quantity = quantity;
            await recipeRepository.Update(recipe);
        }
    }
}
