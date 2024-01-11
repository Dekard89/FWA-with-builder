namespace RecipeRepository
{
    public interface IRepository<T>
    {
        public Task Add(T item);

        public Task Update(T item);

        public Task Delete(T item);

        public List<T> GetAll();
    }
}
