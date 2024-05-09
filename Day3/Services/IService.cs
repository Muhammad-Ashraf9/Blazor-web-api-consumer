namespace Day3.Services
{
    public interface IService<T> where T : class
    {
        public Task<List<T>> GetAll();

        public Task<T> GetById(int id);

        public Task<bool> Update(int  id, T entity);

        public Task Insert(T entity);

        public Task Delete(int id);

    }
}
