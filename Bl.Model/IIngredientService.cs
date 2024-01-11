namespace Bl.Model
{
    public interface IIngredientService<T>
    {
        public T Create(string name, double price, int quantity);
        public Task CreateAndAdd(string name, double price, int quantity);

        public T FindByName(string name);

        public Task UpdatePrice(T entity, double price);

        public Task UpdateQuantity(T entity, int quantity);
    }
}
