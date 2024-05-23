using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientInfoPortal.API.Repositories.IRepositories;
using PatientInfoPortal.Models;
using static PatientInfoPortal.API.Repositories.IRepositories.IGenericRepository;

namespace PatientInfoPortal.API.Controllers
{
    [Route("api/Allergies")]
    [ApiController]
    public class AllergiesController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IGenericRepository<Allergy> repo;
        public AllergiesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.repo = this.unitOfWork.GetRepository<Allergy>();
        }
        [HttpGet]
        public async Task<IEnumerable<Allergy>> GetAllergies()
        {
            var data = await repo.GetAllAsync();

            return data.ToList();
        }
    }
}
