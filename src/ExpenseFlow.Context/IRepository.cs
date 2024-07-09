namespace ExpenseFlow.Context
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteBy(int id);
        IEnumerable<T> GetAll();
        T GetBy(int id);
    }
}