using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SkolaV6.Models
{
    public partial class Kurser
    {
        public Kurser()
        {
            Betyg = new HashSet<Betyg>();
        }

        public int KursId { get; set; }
        public string KursNamn { get; set; }
        public bool? AktivKurs { get; set; }

        public virtual ICollection<Betyg> Betyg { get; set; }
    }
}
