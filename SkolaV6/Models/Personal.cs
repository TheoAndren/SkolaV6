using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SkolaV6.Models
{
    public partial class Personal
    {
        public Personal()
        {
            Betyg = new HashSet<Betyg>();
        }

        public int AnställningsNr { get; set; }
        public string Fnamn { get; set; }
        public string Lnamn { get; set; }
        public string PrsNr { get; set; }
        public int DepartmentId { get; set; }
        public int? Lön { get; set; }
        public int? AntalÅrPåSkolan { get; set; }

        public virtual Befattning Department { get; set; }
        public virtual ICollection<Betyg> Betyg { get; set; }
    }
}
