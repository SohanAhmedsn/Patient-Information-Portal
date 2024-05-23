using PatientInfoPortal.API.Data;
using PatientInfoPortal.API.Repositories.IRepositories;
using static PatientInfoPortal.API.Repositories.IRepositories.IGenericRepository;

namespace PatientInfoPortal.API.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext db;
        public UnitOfWork(AppDbContext db)
        {
            this.db = db;
        }
        public IGenericRepository<T> GetRepository<T>() where T : class, new()
        {
            return new GenericRepository<T>(db);
        }
        public async Task<bool> SaveAsync()
        {
            int rowsEffected = await db.SaveChangesAsync();
            return rowsEffected > 0;
        }
    }
}
