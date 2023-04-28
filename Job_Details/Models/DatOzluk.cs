using System;
using System.Collections.Generic;

namespace Job_Details.Models
{
    public partial class DatOzluk
    {
        public int OzlukId { get; set; }
        public int? UserId { get; set; }
        public string? Uad { get; set; }
        public string? Usoyad { get; set; }
        public string? Udt { get; set; }
        public int? SehirId { get; set; }
        public string? Gsmno { get; set; }

        public virtual DatIlan? Sehir { get; set; }
        public virtual PrmSehir? SehirNavigation { get; set; }
        public virtual DatUser? User { get; set; }
    }
}
