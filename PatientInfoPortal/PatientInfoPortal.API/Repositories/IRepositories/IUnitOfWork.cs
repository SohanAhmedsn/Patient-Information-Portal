using static PatientInfoPortal.API.Repositories.IRepositories.IGenericRepository;

namespace PatientInfoPortal.API.Repositories.IRepositories
{
    public interface IUnitOfWork
    {
        IGenericRepository<T> GetRepository<T>() where T : class, new();
        Task<bool> SaveAsync();
    }
}
