using Microsoft.EntityFrameworkCore;
using PatientInfoPortal.API.Data;
using PatientInfoPortal.Models;

namespace PatientInfoPortal.API.DBMigrationSeedServices
{
    public class DbMigrationAndSeederService(AppDbContext db)
    {
        public async Task MigrateAsync()
        {
            var pendingMigrations = await db.Database.GetPendingMigrationsAsync();
            if (pendingMigrations.Any())
            {
                await db.Database.MigrateAsync();
            }
        }
        public async Task SeedAsync()
        {
            if (!(await db.Allergies.AnyAsync()))
            {
                await db.Allergies.AddRangeAsync(new Allergy[]
               {
                    new Allergy{ AllergyName="Drugs - Penicilin"},
                    new Allergy{ AllergyName="Drugs - Others" },
                    new Allergy{ AllergyName="Oinments"},
                    new Allergy{ AllergyName="Sprays"},
                    new Allergy{ AllergyName="Plant"},
                    new Allergy{ AllergyName="Others"},
                    new Allergy{ AllergyName="No Allergies"},
               });
            }

            if (!await db.NCDs.AnyAsync())
            {
                await db.NCDs.AddRangeAsync(new NCD[]
                {
                new NCD{ NCDName="Asthma"},
                new NCD{ NCDName="Cancer"},
                new NCD{ NCDName="Disorder of eye"},
                new NCD{ NCDName="Disorder of ear"},
                new NCD{ NCDName="Mental Illness"},
                new NCD{ NCDName="Oral Health problems"}
                });
            }
            if (!await db.DiseaseInformations.AnyAsync())
            {
                await db.DiseaseInformations.AddRangeAsync(new DiseaseInformation[]
               {
                    new DiseaseInformation{ DiseaseName="Ulcer"},
                    new DiseaseInformation{ DiseaseName="Hepatitis"},
                    new DiseaseInformation{ DiseaseName="Hypertension"}
               });
            }

            await db.SaveChangesAsync();
        }
    }
}