using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInfoPortal.Models
{
    public class NCD_Detail
    {
        public int Id { get; set; }
        [Required, ForeignKey("Patient")]
        public int PatientId { get; set; }
        [Required, ForeignKey("NCD")]
        public int NCDId { get; set; }
        public virtual NCD NCD { get; set; } = default!;
        public virtual Patient Patient { get; set; } = default!;
    }
}
