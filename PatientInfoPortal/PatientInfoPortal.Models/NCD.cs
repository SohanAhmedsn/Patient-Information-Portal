using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInfoPortal.Models
{
    public class NCD
    {
        public int NCDId { get; set; }
        [Required, StringLength(50)]
        public string NCDName { get; set; } = default!;
        public virtual ICollection<NCD_Detail> NCD_Details { get; set; } = new List<NCD_Detail>();
    }
}
