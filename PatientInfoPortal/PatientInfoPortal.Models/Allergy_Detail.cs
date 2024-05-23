using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInfoPortal.Models
{
    public class Allergy_Detail
    {
        public int Id { get; set; }
        [Required, ForeignKey("Patient")]
        public int PatientId { get; set; }
        [Required, ForeignKey("Allergy")]
        public int AllergyId { get; set; }
        public virtual Allergy Allergy { get; set; } = default!;
        public virtual Patient Patient { get; set; } = default!;
    }
}
