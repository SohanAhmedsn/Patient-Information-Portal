using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientInfoPortal.API.Repositories.IRepositories;
using PatientInfoPortal.Models;
using static PatientInfoPortal.API.Repositories.IRepositories.IGenericRepository;

namespace PatientInfoPortal.API.Controllers
{
    [Route("api/DiseaseInformations")]
    [ApiController]
    public class DiseaseInformationsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IGenericRepository<DiseaseInformation> repo;
        public DiseaseInformationsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.repo = this.unitOfWork.GetRepository<DiseaseInformation>();
        }
        [HttpGet]
        public async Task<IEnumerable<DiseaseInformation>> GetDiseaseInformations()
        {
            var data = await repo.GetAllAsync();

            return data.ToList();
        }
    }
}
