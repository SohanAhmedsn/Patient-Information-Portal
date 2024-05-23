using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInfoPortal.Models
{
    public class DiseaseInformation
    {
        public int DiseaseInformationId { get; set; }
        [Required, StringLength(50)]
        public string DiseaseName { get; set; } = default!;
        public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
    }
}
