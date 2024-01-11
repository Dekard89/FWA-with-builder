using Domain;

namespace Bl.Model
{
    public interface IRecipeService
    {
        public Recipe Create(string name, string image);

        public Recipe FindByName(string name);

        public Task UpdateName(Recipe recipe, string name);

        public Task UpdateImage(Recipe recipe, string image);

        public Task UpdateActive(Recipe recipe);
        public List<Recipe> GetActive();

    }
}
