using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInfoPortal.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        [Required, StringLength(50)]
        public string PatientName { get; set; } = default!;
        [EnumDataType(typeof(EpilepsyType))]
        public EpilepsyType? Epilepsy { get; set; } = default!;
        [Required, ForeignKey("DiseaseInformation")]
        public int DiseaseInformationId { get; set; }
        public virtual DiseaseInformation DiseaseInformation { get; set; } = default!;


        public virtual ICollection<NCD_Detail> NCD_Details { get; set; } = new List<NCD_Detail>();
        public virtual ICollection<Allergy_Detail> Allergy_Details { get; set; } = new List<Allergy_Detail>();
    }
}
