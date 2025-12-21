namespace UserLogin.Repo_Pattern
{
    public interface IGenericRepository<T> where T : class
    {

        Task <IEnumerable<T>> GetAllAsync();

        Task AddAsync(T Entity);
    }
}
