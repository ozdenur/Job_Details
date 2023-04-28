using System;
using System.Collections.Generic;

namespace Job_Details.Models
{
    public partial class PrmSektorBilgisi
    {
        public PrmSektorBilgisi()
        {
            DatSirkets = new HashSet<DatSirket>();
            TblSirketBilgisis = new HashSet<TblSirketBilgisi>();
        }

        public int SektorId { get; set; }
        public string? SektorName { get; set; }

        public virtual ICollection<DatSirket> DatSirkets { get; set; }
        public virtual ICollection<TblSirketBilgisi> TblSirketBilgisis { get; set; }
    }
}
