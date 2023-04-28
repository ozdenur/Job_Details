using System;
using System.Collections.Generic;

namespace Job_Details.Models
{
    public partial class DatUser
    {
        public DatUser()
        {
            DatOzluks = new HashSet<DatOzluk>();
            DatSirkets = new HashSet<DatSirket>();
            JnkBasvurus = new HashSet<JnkBasvuru>();
        }

        public int UserId { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPassword { get; set; }
        public string? UserAtype { get; set; }

        public virtual ICollection<DatOzluk> DatOzluks { get; set; }
        public virtual ICollection<DatSirket> DatSirkets { get; set; }
        public virtual ICollection<JnkBasvuru> JnkBasvurus { get; set; }
    }
}
