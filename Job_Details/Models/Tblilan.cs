using System;
using System.Collections.Generic;

namespace Job_Details.Models
{
    public partial class Tblilan
    {
        public Tblilan()
        {
            Junctions = new HashSet<Junction>();
            TblSirketBilgisis = new HashSet<TblSirketBilgisi>();
        }

        public int Id { get; set; }
        public int? Sirket { get; set; }
        public string? Departman { get; set; }
        public string? Tecrube { get; set; }
        public string? EgitimSeviyesi { get; set; }
        public string? YabancilDil { get; set; }
        public string? CalismaSekli { get; set; }
        public string? Pozisyon { get; set; }
        public int? Sehir { get; set; }
        public string? IlanDetay { get; set; }

        public virtual ICollection<Junction> Junctions { get; set; }
        public virtual ICollection<TblSirketBilgisi> TblSirketBilgisis { get; set; }
    }
}
