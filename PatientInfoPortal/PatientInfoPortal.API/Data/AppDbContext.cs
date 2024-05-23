using Microsoft.EntityFrameworkCore;
using PatientInfoPortal.Models;

namespace PatientInfoPortal.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) { }
        public DbSet<Allergy> Allergies { get; set; }
        public DbSet<NCD> NCDs { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<DiseaseInformation> DiseaseInformations { get; set; }
        public DbSet<NCD_Detail> NCD_Details { get; set; }
        public DbSet<Allergy_Detail> Allergy_Details { get; set; }

    }
}
