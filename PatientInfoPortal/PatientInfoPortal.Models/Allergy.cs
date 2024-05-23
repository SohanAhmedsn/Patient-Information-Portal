using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInfoPortal.Models
{
    public enum EpilepsyType { Yes = 1, No, NotSure }
    public class Allergy
    {
        public int AllergyId { get; set; }
        [Required, StringLength(50)]
        public string AllergyName { get; set; } = default!;
        public virtual ICollection<Allergy_Detail> Allergy_Details { get; set; } = new List<Allergy_Detail>();
    }
}
