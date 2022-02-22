using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SkolaV6.Models
{
    public partial class Elev
    {
        public Elev()
        {
            Betyg = new HashSet<Betyg>();
        }

        public int ElevId { get; set; }
        public string Fnamn { get; set; }
        public string Lnamn { get; set; }
        public string PrsNr { get; set; }
        public int KlassId { get; set; }

        public virtual Klass Klass { get; set; }
        public virtual ICollection<Betyg> Betyg { get; set; }
    }
}
