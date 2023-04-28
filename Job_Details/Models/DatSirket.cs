using System;
using System.Collections.Generic;

namespace Job_Details.Models
{
    public partial class DatSirket
    {
        public DatSirket()
        {
            DatIlans = new HashSet<DatIlan>();
        }

        public int SiretId { get; set; }
        public int? UserId { get; set; }
        public string? ŞirketAd { get; set; }
        public int? SektorId { get; set; }
        public string? Sadres { get; set; }
        public int? SehirId { get; set; }

        public virtual PrmSehir? Sehir { get; set; }
        public virtual PrmSektorBilgisi? Sektor { get; set; }
        public virtual DatUser? User { get; set; }
        public virtual ICollection<DatIlan> DatIlans { get; set; }
    }
}
