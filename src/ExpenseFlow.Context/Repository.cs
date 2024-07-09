
namespace ExpenseFlow.Context
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ExpenseFlowDbContext p_context;
        public Repository(ExpenseFlowDbContext expenseFlowContext)
        {
            p_context = expenseFlowContext;
        }

        public void Add(T entity)
        {
            p_context.Add(entity);
            p_context.SaveChanges();
        }

        public void Delete(T entity)
        {
            p_context.Remove(entity);
            p_context.SaveChanges();
        }

        public void DeleteBy(int id)
        {
            T entity = GetBy(id);
            Delete(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return p_context.Set<T>().ToList();
        }

        public virtual T GetBy(int id)
        {
            return p_context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            p_context.Update(entity);
            p_context.SaveChanges();
        }
    }
}
