using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientInfoPortal.API.Repositories.IRepositories;
using PatientInfoPortal.Models;
using static PatientInfoPortal.API.Repositories.IRepositories.IGenericRepository;

namespace PatientInfoPortal.API.Controllers
{
    [Route("api/NCDs")]
    [ApiController]
    public class NCDsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IGenericRepository<NCD> repo;
        public NCDsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.repo = this.unitOfWork.GetRepository<NCD>();
        }
        [HttpGet]
        public async Task<IEnumerable<NCD>> GetNCDs()
        {
            var data = await repo.GetAllAsync();

            return data.ToList();
        }
    }
}
