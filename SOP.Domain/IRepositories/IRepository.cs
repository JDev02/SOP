namespace SOP.Domain.IRepositories
{
    public interface IRepository<T>
    {
        void Add(T entity);
    }
}