using System;
using System.Collections.Generic;

namespace Job_Details.Models
{
    public partial class DatIlan
    {
        public DatIlan()
        {
            DatOzluks = new HashSet<DatOzluk>();
            JnkBasvurus = new HashSet<JnkBasvuru>();
        }

        public int IlanId { get; set; }
        public int? SirketId { get; set; }
        public string? IlanBaslık { get; set; }
        public string? IlanDetay { get; set; }
        public int? SehirId { get; set; }
        public string? IsTipi { get; set; }

        public virtual PrmSehir? Sehir { get; set; }
        public virtual DatSirket? Sirket { get; set; }
        public virtual ICollection<DatOzluk> DatOzluks { get; set; }
        public virtual ICollection<JnkBasvuru> JnkBasvurus { get; set; }
    }
}
