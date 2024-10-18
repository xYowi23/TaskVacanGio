namespace VacanGio.Repositories
{
    public interface IRepoScrittura<T>
    {
        bool Create(T entity);
        bool Delete(int id);
        bool Update(T entity);
    }
}
